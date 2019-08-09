
using AutoMapper;
using HumanitarianAssistance.Application.CommonModels;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Store.Models;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.Accounting;
using HumanitarianAssistance.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HumanitarianAssistance.Application.CommonServices
{
    internal class StoreServices
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;

        public StoreServices(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ApiResponse AddEditTransactionList(AddEditTransactionModel voucherTransactions, string userId)
        {
            ApiResponse response = new ApiResponse();

            List<VoucherTransactions> transactionsListAdd = new List<VoucherTransactions>();
            List<VoucherTransactions> transactionsListEdit = new List<VoucherTransactions>();

            try
            {
                if (voucherTransactions.VoucherTransactions.Any())
                {

                    var editList = voucherTransactions.VoucherTransactions.Where(w => w.TransactionId != 0)
                                                          .Select(s => s.TransactionId);

                    var editTransactionList = _dbContext.VoucherTransactions
                                                                 .Where(x => editList
                                                                            .Contains(x.TransactionId))
                                                                 .ToList();

                    var voucherDetail = _dbContext.VoucherDetail.FirstOrDefault(x => x.IsDeleted == false && x.VoucherNo == voucherTransactions.VoucherNo);

                    if (voucherDetail != null)
                    {
                        foreach (VoucherTransactionsModel item in voucherTransactions.VoucherTransactions)
                        {
                            // Add
                            if (item.TransactionId == 0 && item.IsDeleted == false)
                            {
                                //new voucher transaction object
                                VoucherTransactions transaction = new VoucherTransactions();

                                transaction.ChartOfAccountNewId = item.AccountNo;
                                transaction.Debit = item.Debit;
                                transaction.Credit = item.Credit;
                                transaction.Description = item.Description;
                                transaction.BudgetLineId = item.BudgetLineId;
                                transaction.ProjectId = item.ProjectId;
                                transaction.CreatedById = userId;
                                transaction.CreatedDate = DateTime.Now;
                                transaction.IsDeleted = false;
                                transaction.VoucherNo = item.VoucherNo;
                                transaction.CurrencyId = voucherDetail.CurrencyId;
                                transaction.TransactionDate = voucherDetail.VoucherDate;
                                transaction.JobId = item.JobId == 0 ? null : item.JobId;

                                transactionsListAdd.Add(transaction);
                            }
                            // edit
                            else
                            {
                                VoucherTransactions transaction = editTransactionList.FirstOrDefault(x => x.TransactionId == item.TransactionId);

                                if (transaction != null)
                                {
                                    if (item.IsDeleted == false)
                                    {
                                        transaction.IsDeleted = false;
                                    }
                                    else
                                    {
                                        transaction.IsDeleted = true;
                                    }
                                    transaction.TransactionId = item.TransactionId;
                                    transaction.ChartOfAccountNewId = item.AccountNo;
                                    transaction.Debit = item.Debit;
                                    transaction.Credit = item.Credit;
                                    transaction.Description = item.Description;
                                    transaction.BudgetLineId = item.BudgetLineId;
                                    transaction.ProjectId = item.ProjectId;
                                    transaction.JobId = item.JobId == 0 ? null : item.JobId;
                                    transaction.CurrencyId = voucherDetail.CurrencyId;
                                    transaction.TransactionDate = voucherDetail.VoucherDate;
                                    transaction.ModifiedById = userId;
                                    transaction.ModifiedDate = DateTime.Now;
                                    //transaction.VoucherNo = voucherTransactions.VoucherNo;

                                    transactionsListEdit.Add(transaction);
                                }
                            }
                        }

                        using (IDbContextTransaction tran = _dbContext.Database.BeginTransaction())
                        {
                            try
                            {
                                _dbContext.VoucherTransactions.AddRange(transactionsListAdd);
                                _dbContext.VoucherTransactions.UpdateRange(transactionsListEdit);

                                _dbContext.SaveChanges();
                                tran.Commit();
                            }

                            catch (Exception ex)
                            {
                                tran.Rollback();
                                response.StatusCode = StaticResource.failStatusCode;
                                response.Message = StaticResource.SomethingWrong + ex.Message;
                                return response;
                            }
                        }

                        response.StatusCode = StaticResource.successStatusCode;
                        response.Message = StaticResource.SuccessText;
                    }
                    else
                    {
                        response.StatusCode = StaticResource.failStatusCode;
                        response.Message = StaticResource.VoucherNotPresent;
                    }
                }
                else
                {
                    response.StatusCode = StaticResource.failStatusCode;
                    response.Message = StaticResource.SomethingWrong;
                }
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