using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.Accounting.Commands.Create
{
    public class AddVoucherDetailCommandHandler : IRequestHandler<AddVoucherDetailCommand, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;

        public AddVoucherDetailCommandHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ApiResponse> Handle(AddVoucherDetailCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                request.TimezoneOffset = request.TimezoneOffset > 0 ? request.TimezoneOffset * -1 : Math.Abs(request.TimezoneOffset.Value);

                DateTime filterVoucherDate = request.VoucherDate.AddMinutes(request.TimezoneOffset.Value);

                Task<List<CurrencyDetails>> currencyListTask = _dbContext.CurrencyDetails.Where(x => x.IsDeleted == false).ToListAsync();

                if (request.IsExchangeGainLossVoucher)
                {
                    request.VoucherDate = DateTime.UtcNow;
                }

                Task<List<ExchangeRateDetail>> exchangeRatePresentTask = _dbContext.ExchangeRateDetail.Where(x => x.Date.Date == request.VoucherDate.Date && x.IsDeleted == false).ToListAsync();

                List<CurrencyDetails> currencyList = await currencyListTask;

                List<int> currencyIds = currencyList.Select(x => x.CurrencyId).ToList();

                string currencyCode = currencyList.FirstOrDefault(x => x.CurrencyId == request.CurrencyId).CurrencyCode;

                List<ExchangeRateDetail> exchangeRatePresent = await exchangeRatePresentTask;

                if (CheckExchangeRateIsPresent(currencyIds, exchangeRatePresent))
                {
                    var officeDetail = await _dbContext.OfficeDetail.FirstOrDefaultAsync(o => o.OfficeId == request.OfficeId); //use OfficeCode

                    if (officeDetail != null)
                    {
                        Task<FinancialYearDetail> fincancialYearTask = _dbContext.FinancialYearDetail.FirstOrDefaultAsync(o => o.IsDefault);
                        Task<CurrencyDetails> currencyDetailTask = _dbContext.CurrencyDetails.FirstOrDefaultAsync(o => o.CurrencyId == request.CurrencyId);
                        // NOTE: Dont remove this as we will need journal details in response
                        Task<JournalDetail> journaldetailTask = _dbContext.JournalDetail.FirstOrDefaultAsync(o => o.JournalCode == request.JournalCode);
                        int voucherCount = await _dbContext.VoucherDetail.Where(x => x.VoucherDate.Month == request.VoucherDate.Month && x.VoucherDate.Year == filterVoucherDate.Year && x.OfficeId == request.OfficeId && x.CurrencyId == request.CurrencyId).CountAsync();

                        FinancialYearDetail fincancialYear = await fincancialYearTask;

                        if (fincancialYear != null)
                        {
                            CurrencyDetails currencyDetail = await currencyDetailTask;

                            if (currencyDetail != null)
                            {
                                JournalDetail journaldetail = await journaldetailTask;

                                VoucherDetail obj = _mapper.Map<VoucherDetail>(request);
                                obj.JournalCode = journaldetail != null ? journaldetail.JournalCode : request.JournalCode;
                                obj.FinancialYearId = fincancialYear.FinancialYearId;
                                obj.CreatedById = request.CreatedById;
                                obj.VoucherDate = request.VoucherDate;
                                obj.CreatedDate = DateTime.UtcNow;
                                obj.IsDeleted = false;

                                // Pattern: Office Code - Currency Code - Month Number - voucher count on selected month - Year
                                string referenceNo = AccountingUtility.GenerateVoucherReferenceCode(request.VoucherDate, voucherCount, currencyDetail.CurrencyCode, officeDetail.OfficeCode);

                                int sameVoucherReferenceNoCount = 0;

                                if (!string.IsNullOrEmpty(referenceNo))
                                {
                                    do
                                    {
                                        sameVoucherReferenceNoCount = await _dbContext.VoucherDetail.Where(x => x.ReferenceNo == referenceNo).CountAsync();

                                        if (sameVoucherReferenceNoCount == 0)
                                        {
                                            obj.ReferenceNo = referenceNo;
                                        }
                                        else
                                        {
                                            //DO NOT REMOVE: This is used to get the latest voucher and then we will get the count of vouhcer sequence from it
                                            // VoucherDetail voucherDetail = _dbContext.VoucherDetail.OrderByDescending(x => x.VoucherDate).FirstOrDefault(x => x.VoucherDate.Month == filterVoucherDate.Month && x.OfficeId == request.OfficeId && x.VoucherDate.Year == filterVoucherDate.Year);

                                            var refNo = referenceNo.Split('-');
                                            int count = Convert.ToInt32(refNo[3]);
                                            referenceNo = AccountingUtility.GenerateVoucherReferenceCode(request.VoucherDate, count, currencyCode, officeDetail.OfficeCode);
                                        }
                                    }
                                    while (sameVoucherReferenceNoCount != 0);
                                }

                                await _dbContext.VoucherDetail.AddAsync(obj);
                                await _dbContext.SaveChangesAsync();

                                VoucherDetailEntityModel voucherModel = _mapper.Map<VoucherDetail, VoucherDetailEntityModel>(obj);

                                response.data.VoucherDetailEntity = voucherModel;
                                response.StatusCode = StaticResource.successStatusCode;
                                response.Message = StaticResource.SuccessText;
                            }
                            else
                            {
                                response.StatusCode = StaticResource.failStatusCode;
                                response.Message = StaticResource.CurrencyNotFound;
                            }
                        }
                        else
                        {
                            response.StatusCode = StaticResource.failStatusCode;
                            response.Message = StaticResource.defaultFinancialYearIsNotSet;
                        }
                    }
                    else
                    {
                        response.StatusCode = StaticResource.failStatusCode;
                        response.Message = StaticResource.officeCodeNotFound;
                    }
                }
                else
                {
                    response.StatusCode = StaticResource.failStatusCode;
                    response.Message = StaticResource.ExchagneRateNotDefined;
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = ex.Message;
            }
            return response;
        }

        /// <summary>
        /// check if Exchange Rate is present or not
        /// </summary>
        /// <param name="currencyList"></param>
        /// <param name="exchangeRatePresedsnt"></param>
        /// <returns>false</returns>
        /// <returns>true</returns>
        public bool CheckExchangeRateIsPresent(List<int> currencyList, List<ExchangeRateDetail> exchangeRates)
        {
            var groupedDataCount = exchangeRates.GroupBy(x => new { x.FromCurrency, x.ToCurrency }).ToList().Count;
            if (groupedDataCount >= (int)Math.Pow(currencyList.Count(), 2))
            {
                return true;
            }
            return false;
        }
    }
}