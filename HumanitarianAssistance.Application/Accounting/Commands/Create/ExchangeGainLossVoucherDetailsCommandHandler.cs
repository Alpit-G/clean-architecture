using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Persistence;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Commands.Create
{
    public class ExchangeGainLossVoucherDetailsCommandHandler: IRequestHandler<ExchangeGainLossVoucherDetailsCommand, ApiResponse>
    {
      private HumanitarianAssistanceDbContext _dbContext;

        public ExchangeGainLossVoucherDetailsCommandHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ApiResponse> CreateGainLossTransaction(ExchangeGainLossVoucherDetailsCommand model, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                #region "Generate Voucher"
                VoucherDetailModel voucherModel = new VoucherDetailModel
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

                var responseVoucher = await AddVoucherNewDetail(voucherModel);

                #endregion

                #region "Generate Transaction"

                if (responseVoucher.StatusCode == 200)
                {
                    List<VoucherTransactionsModel> transactions = new List<VoucherTransactionsModel>();

                    // Credit
                    transactions.Add(new VoucherTransactionsModel
                    {
                        TransactionId = 0,
                        VoucherNo = responseVoucher.data.VoucherDetailEntity.VoucherNo,
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
                        VoucherNo = responseVoucher.data.VoucherDetailEntity.VoucherNo,
                        AccountNo = model.DebitAccount,
                        Debit = Math.Abs(model.Amount),
                        Credit = 0,
                        Description = "Gain-Loss-Voucher-Debit",
                        IsDeleted = false
                    });

                    AddEditTransactionModel transactionVoucherDetail = new AddEditTransactionModel
                    {
                        VoucherNo = responseVoucher.data.VoucherDetailEntity.VoucherNo,
                        VoucherTransactions = transactions
                    };

                    var responseTransaction = AddEditTransactionList(transactionVoucherDetail, userId);

                    if (responseTransaction.StatusCode == 200)
                    {
                        string voucherName = _dbContext.VoucherDetail.FirstOrDefault(x => x.JournalCode == responseVoucher.data.VoucherDetailEntity.JournalCode)?.JournalDetails.JournalName;

                        response.data.GainLossVoucherDetail = new GainLossVoucherList
                        {
                            VoucherId = responseVoucher.data.VoucherDetailEntity.VoucherNo,
                            JournalName = voucherName != null ? voucherName : "",
                            VoucherName = responseVoucher.data.VoucherDetailEntity.ReferenceNo,
                            VoucherDate = responseVoucher.data.VoucherDetailEntity.VoucherDate
                        };
                    }
                    else
                    {
                        throw new Exception(responseTransaction.Message);
                    }

                    response.StatusCode = StaticResource.successStatusCode;
                    response.Message = StaticResource.SuccessText;
                }
                else
                {
                    response.StatusCode = StaticResource.failStatusCode;
                    response.Message = responseVoucher.Message;
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