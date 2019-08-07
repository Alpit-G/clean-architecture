using System;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Accounting.Queries;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Enums;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HumanitarianAssistance.WebApi.Controllers.Accounting
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/AccountReports/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Accounting))]
    [Authorize]
    public class AccountReportsController : BaseController
    {
        /// <summary>
        /// Get All Account Balances (Balance Sheet Report)
        /// </summary>
        /// <remarks>
        /// Sample input:
        ///
        ///     POST /GetAllAccountBalancesByCategory
        ///        {
        ///              "id": 0,
        ///              "asOfDate": "2019-07-02T07:07:00.860Z",
        ///              "upToDate": "2019-07-02T07:07:00.860Z",
        ///              "currency": 0
        ///        }
        ///
        /// Sample output:
        ///
        ///      {
        ///          "StatusCode": 200,
        ///          "Message": "Success",
        ///          "data": {
        ///               NoteAccountBalances: [
        ///                     {
        ///                          AccountBalances: [
        ///                              {
        ///                                  AccountId: 86, 
        ///                                  AccountName: "Assets 110301", 
        ///                                  Balance: 8096.8, 
        ///                                  AccountCode: "110301"
        ///                              }
        ///                          ],
        ///                          NoteHeadId: 1,
        ///                          NoteId: 45,
        ///                          NoteName: "Assets 8"
        ///                     }
        ///               ]
        ///           }
        ///     }
        ///
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ApiResponse> GetAllAccountBalancesByCategory([FromBody] GetAllAccountBalancesByCategoryQuery model)
        {
            return await _mediator.Send(model);
        }

        [HttpPost]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ApiResponse> GetVoucherTransactionList([FromBody] GetVoucherTransactionListQuery model)
        {
            return await _mediator.Send(model);
        }

        /// <summary>
        /// Get Trial Balance Report
        /// </summary>
        /// <remarks>
        /// Sample input:
        ///
        ///     POST /GetTrialBalanceReport
        ///     {
        ///         "OfficesList": [
        ///           0
        ///         ],
        ///         "OfficeIdList": [
        ///           0
        ///         ],
        ///         "CurrencyId": 0,
        ///         "fromdate": "2017-07-01T13:22:23.039Z",
        ///         "todate": "2019-07-01T13:22:23.039Z",
        ///         "RecordType": 0,
        ///         "accountLists": [
        ///           0
        ///         ],
        ///         "Take": 0,
        ///         "Skip": 0
        ///     }
        ///
        ///
        /// Sample output:
        ///
        ///      {
        ///          "StatusCode": 200,
        ///          "Message": "Success",
        ///          "data": {
        ///               TrialBalanceList: [
        ///                  {
        ///                     AccountName: "Owners 210102"
        ///                     Amount: 0
        ///                     ChartOfAccountNewCode: "210102"
        ///                     ChartOfAccountNewId: 8
        ///                     CreditAmount: 271810
        ///                     CurrencyName: "Afghanistan"
        ///                     DebitAmount: 0
        ///                     Description: "Testing 2"
        ///                     TotalCredit: 0
        ///                     TotalDebit: 0
        ///                     TransactionDate: "2018-12-21T00:00:00"
        ///                     TransactionNo: 0                 
        ///                 }
        ///               ]
        ///           }
        ///     }
        ///
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ApiResponse> GetTrialBalanceReport([FromBody] GetTrialBalanceReportQuery model)
        {
            return await _mediator.Send(model);
        }

    }
}