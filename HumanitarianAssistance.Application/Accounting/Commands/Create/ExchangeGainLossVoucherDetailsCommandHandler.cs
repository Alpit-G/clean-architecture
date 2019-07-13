using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.Accounting.Commands.Common;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.CommonFunctions;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Persistence;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Commands.Create
{
    public class ExchangeGainLossVoucherDetailsCommandHandler: IRequestHandler<ExchangeGainLossVoucherDetailsCommand, ApiResponse>
    {
      private HumanitarianAssistanceDbContext _dbContext;
      private IMapper _mapper;

        public ExchangeGainLossVoucherDetailsCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper= mapper;
        }

        public async Task<ApiResponse> Handle(ExchangeGainLossVoucherDetailsCommand model, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                #region "Generate Voucher"
                AddVoucherDetailCommand voucherModel = new AddVoucherDetailCommand
                {
                    VoucherNo = model.VoucherNo,
                    CurrencyId = model.CurrencyId,
                    Description = model.Description,
                    JournalCode = model.JournalId,
                    VoucherTypeId = model.VoucherType,
                    OfficeId = model.OfficeId,
                    ProjectId = model.ProjectId,
                    BudgetLineId = model.BudgetLineId,
                    IsExchangeGainLossVoucher = true
                };

                AccountingFunctions accountingFunctions= new AccountingFunctions(_dbContext, _mapper);
                var responseVoucher = await accountingFunctions.AddVoucherDetail(voucherModel);

                #endregion

                #region "Generate Transaction"

                if (responseVoucher != null)
                {
                    List<VoucherTransactionsModel> transactions = new List<VoucherTransactionsModel>();

                    // Credit
                    transactions.Add(new VoucherTransactionsModel
                    {
                        TransactionId = 0,
                        VoucherNo = responseVoucher.VoucherNo,
                        AccountNo = model.CreditAccount,
                        Debit = 0,
                        Credit = Math.Abs(model.Amount),
                        Description = "Gain-Loss-Voucher-Credit",
                        IsDeleted = false
                    });

                    // Debit
                    transactions.Add(new VoucherTransactionsModel
                    {
                        TransactionId = 0,
                        VoucherNo = responseVoucher.VoucherNo,
                        AccountNo = model.DebitAccount,
                        Debit = Math.Abs(model.Amount),
                        Credit = 0,
                        Description = "Gain-Loss-Voucher-Debit",
                        IsDeleted = false
                    });

                    AddEditTransactionListCommand transactionVoucherDetail = new AddEditTransactionListCommand
                    {
                        VoucherNo = responseVoucher.VoucherNo,
                        VoucherTransactions = transactions
                    };

                    bool isTransactionSaved = accountingFunctions.AddEditTransactionList(transactionVoucherDetail);

                    if (isTransactionSaved)
                    {
                        string voucherName = _dbContext.VoucherDetail.FirstOrDefault(x => x.JournalCode == responseVoucher.JournalCode)?.JournalDetails.JournalName;

                        response.data.GainLossVoucherDetail = new GainLossVoucherListModel
                        {
                            VoucherId = responseVoucher.VoucherNo,
                            JournalName = voucherName != null ? voucherName : "",
                            VoucherName = responseVoucher.ReferenceNo,
                            VoucherDate = responseVoucher.VoucherDate
                        };
                    }
                    else
                    {
                        throw new Exception(StaticResource.TransactionsNotSaved);
                    }

                    response.StatusCode = StaticResource.successStatusCode;
                    response.Message = StaticResource.SuccessText;
                }
                else
                {
                    response.StatusCode = StaticResource.failStatusCode;
                    response.Message = StaticResource.VoucherNotSaved;
                }

                #endregion
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = StaticResource.SomethingWrong + ex.Message;
            }
            return response;
        } 
    }
}