using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities;
using HumanitarianAssistance.Domain.Entities.Accounting;
using HumanitarianAssistance.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.CommonFunctions
{
    internal class AccountBalanceFunctions
    {

        private readonly HumanitarianAssistanceDbContext _dbContext;

        public AccountBalanceFunctions(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Generate view models for key value pairs of accounts(full objects) and their balances.
        // Dictionaries cannot be converted to json objects properly by the framework so use
        // this helper function to prepare your account balances for json.
        internal List<AccountBalanceModel> GenerateBalanceViewModels(Dictionary<ChartOfAccountNew, double> rawBalances)
        {
            List<AccountBalanceModel> vmBalances = new List<AccountBalanceModel>();
            foreach (var balance in rawBalances)
            {
                var iVmBalance = new AccountBalanceModel
                {
                    AccountId = balance.Key.ChartOfAccountNewId,
                    AccountName = balance.Key.AccountName,
                    Balance = new Decimal(balance.Value),
                    AccountCode = balance.Key.ChartOfAccountNewCode
                };
                vmBalances.Add(iVmBalance);
            }

            return vmBalances;
        }

        public async Task<ApiResponse> GetAccountBalancesById(List<long> accountIds, int toCurrencyId, DateTime reportDate)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var inputLevelList = await _dbContext.ChartOfAccountNew
                    .Where(x => accountIds.Contains(x.ChartOfAccountNewId)).ToListAsync();


                if (inputLevelList.Any(x => x.AccountTypeId == null))
                    throw new Exception("Some accounts do not have notes assigned to them!");

                var accountBalances = await GetAccountBalances(inputLevelList, reportDate, toCurrencyId);
                var vmNoteBalances = GenerateBalanceViewModels(accountBalances);

                response.data.AccountBalances = vmNoteBalances;
                response.StatusCode = StaticResource.successStatusCode;
                response.Message = "Success";
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ApiResponse> GetAccountBalancesById(List<long> accountIds, DateTime transactionExchangeDate, int toCurrencyId,
            DateTime reportDate)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var inputLevelList = await _dbContext.ChartOfAccountNew
                    .Where(x => accountIds.Contains(x.ChartOfAccountNewId)).ToListAsync();


                if (inputLevelList.Any(x => x.AccountTypeId == null))
                    throw new Exception("Some accounts do not have notes assigned to them!");

                var accountBalances = await GetAccountBalances(inputLevelList, reportDate, transactionExchangeDate, toCurrencyId);
                var vmNoteBalances = GenerateBalanceViewModels(accountBalances);

                response.data.AccountBalances = vmNoteBalances;
                response.StatusCode = StaticResource.successStatusCode;
                response.Message = "Success";
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ApiResponse> GetAccountBalancesById(List<long> accountIds, int toCurrencyId,
            DateTime reportStartDate, DateTime reportEndDate)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var inputLevelList = await _dbContext.ChartOfAccountNew
                    .Where(x => accountIds.Contains(x.ChartOfAccountNewId)).ToListAsync();


                if (inputLevelList.Any(x => x.AccountTypeId == null))
                    throw new Exception("Some accounts do not have notes assigned to them!");

                var accountBalances = await GetAccountBalances(inputLevelList, toCurrencyId, reportStartDate, reportEndDate);
                var vmNoteBalances = GenerateBalanceViewModels(accountBalances);

                response.data.AccountBalances = vmNoteBalances;
                response.StatusCode = StaticResource.successStatusCode;
                response.Message = "Success";
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ApiResponse> GetAccountBalancesById(List<long> accountIds, DateTime transactionExchangeDate, int toCurrencyId,
            DateTime reportStartDate, DateTime reportEndDate)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var inputLevelList = await _dbContext.ChartOfAccountNew
                    .Where(x => accountIds.Contains(x.ChartOfAccountNewId)).ToListAsync();


                if (inputLevelList.Any(x => x.AccountTypeId == null))
                    throw new Exception("Some accounts do not have notes assigned to them!");

                var accountBalances = await GetAccountBalances(inputLevelList, toCurrencyId, reportStartDate, reportEndDate, transactionExchangeDate);
                var vmNoteBalances = GenerateBalanceViewModels(accountBalances);

                response.data.AccountBalances = vmNoteBalances;
                response.StatusCode = StaticResource.successStatusCode;
                response.Message = "Success";
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = ex.Message;
            }

            return response;
        }

         private async Task<List<VoucherTransactions>> GetAccountTransactions(List<ChartOfAccountNew> inputLevelAccounts, DateTime endDate)
        {
            return await _dbContext.VoucherTransactions
                .Where(x => x.TransactionDate != null ? x.TransactionDate.Value.Date <= endDate.Date : x.TransactionDate <= endDate
                            && inputLevelAccounts.Select(y => y.ChartOfAccountNewId).Contains((long)x.ChartOfAccountNewId)
                            && x.IsDeleted == false
                            && x.ChartOfAccountNewId != null)
                .Include(x => x.ChartOfAccountDetail)
                .ToListAsync();
        }

        private async Task<List<VoucherTransactions>> GetAccountTransactions(List<ChartOfAccountNew> inputLevelAccounts, DateTime startDate,
            DateTime endDate)
        {
            return await _dbContext.VoucherTransactions
                .Where(x => x.TransactionDate != null ? x.TransactionDate.Value.Date <= endDate.Date : x.TransactionDate <= endDate
                            && x.TransactionDate != null ? x.TransactionDate.Value.Date >= startDate.Date : x.TransactionDate >= startDate
                            && inputLevelAccounts.Select(y => y.ChartOfAccountNewId).Contains((long)x.ChartOfAccountNewId)
                            && x.IsDeleted == false
                            && x.ChartOfAccountNewId != null)
                .Include(x => x.ChartOfAccountDetail)
                .ToListAsync();
        }

        private double DetermineTransactionExrate(VoucherTransactions transaction,
            List<ExchangeRateDetail> rates, int toCurrencyId)
        {
            double xExchangeRate = 0.0;
            if (transaction.CurrencyId == toCurrencyId)
                xExchangeRate = 1.0;
            else
            {
                if (transaction.TransactionDate == null)
                    throw new Exception("Transaction date is not set");
                if (transaction.CurrencyId == null)
                    throw new Exception("Transaction currency is not set");
                var interxExchangeRate = rates.OrderByDescending(x => x.Date)
                    .FirstOrDefault(x => x.Date <= transaction.TransactionDate.GetValueOrDefault()
                                         && x.FromCurrency == transaction.CurrencyId
                                         && x.ToCurrency == toCurrencyId);
                if (interxExchangeRate == null)
                    throw new Exception("No valid exchange rate exists for the given report's currency");
                xExchangeRate = (double)interxExchangeRate.Rate;
            }

            return xExchangeRate;

        }

        private double DetermineTransactionExrate(VoucherTransactions transaction,
            List<ExchangeRateDetail> rates, int toCurrencyId, DateTime onDate)
        {
            double xExchangeRate = 0.0;
            if (transaction.CurrencyId == toCurrencyId)
                xExchangeRate = 1.0;
            else
            {
                if (transaction.TransactionDate == null)
                    throw new Exception("Transaction date is not set");
                if (transaction.CurrencyId == null)
                    throw new Exception("Transaction currency is not set");
                var interxExchangeRate = rates.OrderByDescending(x => x.Date)
                    .FirstOrDefault(x => x.Date <= onDate
                                         && x.FromCurrency == transaction.CurrencyId
                                         && x.ToCurrency == toCurrencyId);
                if (interxExchangeRate == null)
                    throw new Exception("No valid exchange rate exists for the given report's currency");
                xExchangeRate = (double)interxExchangeRate.Rate;
            }

            return xExchangeRate;

        }

        // Value after exchange on the transaction date
        private async Task<List<VoucherTransactions>> GetTransactionValuesAfterExchange(List<VoucherTransactions> transactions, int toCurrencyId)
        {
            var ratesQuery = _dbContext.ExchangeRateDetail.Where(x => x.ToCurrency == toCurrencyId
                                                                               && transactions.Select(y => y.CurrencyId).Contains(x.FromCurrency)
                                                                               && transactions.Select(y => y.TransactionDate).Any(z => z >= x.Date));
            var ratesList = await ratesQuery.ToListAsync();

            List<VoucherTransactions> outputTransactions = new List<VoucherTransactions>();

            foreach (var transaction in transactions)
            {
                var rate = DetermineTransactionExrate(transaction, ratesList, toCurrencyId);

                var outputTransaction = (transaction);
                outputTransaction.Credit = rate * transaction.Credit;
                outputTransaction.Debit = rate * transaction.Debit;
                outputTransactions.Add(outputTransaction);
            }

            return outputTransactions;
        }

        private Dictionary<ChartOfAccountNew, double> CalculateAccountBalances(
            List<ChartOfAccountNew> inputLevelAccounts, List<VoucherTransactions> accountTransactions)
        {
            Dictionary<ChartOfAccountNew, double> accountBalances = new Dictionary<ChartOfAccountNew, double>();

            foreach (var account in inputLevelAccounts)
            {
                var currAccountTransactions =
                    accountTransactions.Where(x => x.ChartOfAccountNewId == account.ChartOfAccountNewId).ToList();
                var totalCredits = currAccountTransactions.Select(x => x.Credit.GetValueOrDefault()).Sum();
                var totalDebits = currAccountTransactions.Select(x => x.Debit.GetValueOrDefault()).Sum();
                if (account.IsCreditBalancetype.GetValueOrDefault())
                    accountBalances.Add(account, totalCredits - totalDebits);
                else
                    accountBalances.Add(account, totalDebits - totalCredits);
            }

            return accountBalances;
        }

        // thhis override calculates transaction credit/debit value after exchange on the transaction date
        internal async Task<Dictionary<ChartOfAccountNew, double>> GetAccountBalances(List<ChartOfAccountNew> inputLevelAccounts, DateTime transactionsTillDate,
            int toCurrencyId)
        {
            var transactions = await GetAccountTransactions(inputLevelAccounts, transactionsTillDate);
            var exchangeValuedTransactions = await GetTransactionValuesAfterExchange(transactions, toCurrencyId);

            return CalculateAccountBalances(inputLevelAccounts, exchangeValuedTransactions);
        }

        // this override calculates transaction credit/debit values after exchange based on the given transactionCompareDate
        internal async Task<Dictionary<ChartOfAccountNew, double>> GetAccountBalances(List<ChartOfAccountNew> inputLevelAccounts, DateTime transactionsTillDate,
            DateTime transactionExchangeDate, int toCurrencyId)
        {
            var transactions = await GetAccountTransactions(inputLevelAccounts, transactionsTillDate);
            var exchangeValuedTransactions = await GetTransactionValuesAfterExchange(transactions, toCurrencyId, transactionExchangeDate);

            return CalculateAccountBalances(inputLevelAccounts, exchangeValuedTransactions);
        }

        internal async Task<Dictionary<ChartOfAccountNew, double>> GetAccountBalances(List<ChartOfAccountNew> inputLevelAccounts,
            int toCurrencyId, DateTime transactionsStartingFrom, DateTime transactionsUntil)
        {
            var transactions = await GetAccountTransactions(inputLevelAccounts, transactionsStartingFrom, transactionsUntil);
            var exchangeValuedTransactions = await GetTransactionValuesAfterExchange(transactions, toCurrencyId);

            return CalculateAccountBalances(inputLevelAccounts, exchangeValuedTransactions);
        }

        internal async Task<Dictionary<ChartOfAccountNew, double>> GetAccountBalances(List<ChartOfAccountNew> inputLevelAccounts,
            int toCurrencyId, DateTime transactionsStartingFrom, DateTime transactionsUntil, DateTime transactionExchangeDate)
        {
            var transactions = await GetAccountTransactions(inputLevelAccounts, transactionsStartingFrom, transactionsUntil);
            var exchangeValuedTransactions = await GetTransactionValuesAfterExchange(transactions, toCurrencyId, transactionExchangeDate);

            return CalculateAccountBalances(inputLevelAccounts, exchangeValuedTransactions);
        }

        private async Task<List<VoucherTransactions>> GetAccountTransactions(List<ChartOfAccountNew> inputLevelAccounts, DateTime startDate,
            DateTime endDate, List<int?> journalList, List<int?> officeList, List<long?> projectIdList)
        {
            var data = await _dbContext.VoucherTransactions
                .Where(x => x.TransactionDate <= endDate
                            && x.TransactionDate >= startDate
                            && inputLevelAccounts.Select(y => y.ChartOfAccountNewId).Contains((long)x.ChartOfAccountNewId)
                            && x.IsDeleted == false
                            && x.ChartOfAccountNewId != null
                            && officeList.Contains(x.VoucherDetails.OfficeId)
                            && journalList.Contains(x.VoucherDetails.JournalCode)
                            //&& projectIdList.Contains(x.VoucherDetails.ProjectId)
                            && projectIdList.Contains(x.ProjectId)
                            )
                .Include(x => x.ChartOfAccountDetail)
                .Include(x => x.VoucherDetails)
                .ToListAsync();
            return data;
        }

        internal async Task<Dictionary<ChartOfAccountNew, double>> GetAccountBalances(List<ChartOfAccountNew> inputLevelAccounts,
           int toCurrencyId, DateTime transactionsStartingFrom, DateTime transactionsUntil, List<int?> journalList, List<int?> officeList, List<long?> projectIdList)
        {
            var transactions = await GetAccountTransactions(inputLevelAccounts, transactionsStartingFrom, transactionsUntil, journalList, officeList, projectIdList);
            var exchangeValuedTransactions = await GetTransactionValuesAfterExchange(transactions, toCurrencyId);

            return CalculateAccountBalances(inputLevelAccounts, exchangeValuedTransactions);
        }

        public async Task<ApiResponse> GetAccountBalancesById(List<long?> accountIds, int toCurrencyId,
            DateTime reportStartDate, DateTime reportEndDate, List<int?> journalList, List<int?> officeList, List<long?> projectIdList)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var inputLevelList = await _dbContext.ChartOfAccountNew
                    .Where(x => accountIds.Contains(x.ChartOfAccountNewId)).ToListAsync();


                if (inputLevelList.Any(x => x.AccountTypeId == null))
                    throw new Exception("Some accounts do not have notes assigned to them!");

                var accountBalances = await GetAccountBalances(inputLevelList, toCurrencyId, reportStartDate, reportEndDate, journalList, officeList, projectIdList);
                var vmNoteBalances = GenerateBalanceViewModels(accountBalances);

                response.data.AccountBalances = vmNoteBalances;
                response.StatusCode = StaticResource.successStatusCode;
                response.Message = "Success";
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ApiResponse> GetAccountBalancesById(List<long?> accountIds, DateTime transactionExchangeDate, int toCurrencyId,
           DateTime reportStartDate, DateTime reportEndDate, List<int?> journalList, List<int?> officeList, List<long?> projectIdList)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var inputLevelList = await _dbContext.ChartOfAccountNew
                    .Where(x => accountIds.Contains(x.ChartOfAccountNewId)).ToListAsync();


                if (inputLevelList.Any(x => x.AccountTypeId == null))
                    throw new Exception("Some accounts do not have notes assigned to them!");

                var accountBalances = await GetAccountBalances(inputLevelList, toCurrencyId, reportStartDate, reportEndDate, transactionExchangeDate, journalList, officeList, projectIdList);
                var vmNoteBalances = GenerateBalanceViewModels(accountBalances);

                response.data.AccountBalances = vmNoteBalances;
                response.StatusCode = StaticResource.successStatusCode;
                response.Message = "Success";
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = ex.Message;
            }

            return response;
        }

        internal async Task<Dictionary<ChartOfAccountNew, double>> GetAccountBalances(List<ChartOfAccountNew> inputLevelAccounts,
            int toCurrencyId, DateTime transactionsStartingFrom, DateTime transactionsUntil, DateTime transactionExchangeDate, List<int?> journalList, List<int?> officeList, List<long?> projectIdList)
        {
            var transactions = await GetAccountTransactions(inputLevelAccounts, transactionsStartingFrom, transactionsUntil, journalList, officeList, projectIdList);
            var exchangeValuedTransactions = await GetTransactionValuesAfterExchange(transactions, toCurrencyId, transactionExchangeDate);

            return CalculateAccountBalances(inputLevelAccounts, exchangeValuedTransactions);
        }

        // Value after exchange on the given onDate
        private async Task<List<VoucherTransactions>> GetTransactionValuesAfterExchange(List<VoucherTransactions> transactions, int toCurrencyId, DateTime onDate)
        {
            if (!transactions.Any())
            {
                throw new Exception("Transaction not found");
            }

            var ratesQuery = _dbContext.ExchangeRateDetail.Where(x => x.ToCurrency == toCurrencyId
                                                                               && transactions.Select(y => y.CurrencyId).Contains(x.FromCurrency)
                                                                               && x.Date.ToShortDateString() == onDate.ToShortDateString());
            var ratesList = await ratesQuery.ToListAsync();

            if (!ratesList.Any())
            {
                throw new Exception("Exchange Rate Not Defined On Selected Comparision Date");
            }

            List<VoucherTransactions> outputTransactions = new List<VoucherTransactions>();

            foreach (var transaction in transactions)
            {
                var rate = DetermineTransactionExrate(transaction, ratesList, toCurrencyId, onDate);

                var outputTransaction = (transaction);
                outputTransaction.Credit = rate * transaction.Credit;
                outputTransaction.Debit = rate * transaction.Debit;
                outputTransactions.Add(outputTransaction);
            }

            return outputTransactions;
        }

    }
}