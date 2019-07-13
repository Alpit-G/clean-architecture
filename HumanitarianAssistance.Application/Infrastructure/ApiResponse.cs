using System;
using System.Collections.Generic;
using System.Text;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Marketing.Models;
using HumanitarianAssistance.Domain.Entities.Accounting;
using HumanitarianAssistance.Domain.Entities.Marketing;

namespace HumanitarianAssistance.Application.Infrastructure
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            data = new Data();
            ItemAmount = new ItemAmount();
            CommonId = new CommonId();
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public Data data { get; set; }
        public dynamic ResponseData { get; set; }
        public LoggerDetailsModel LoggerDetailsModel { get; set; }
        public ItemAmount ItemAmount { get; set; }
        public CommonId CommonId { get; set; }

    }
    public class Data
    {

        // login
        public string AspNetUserId { get; set; }
        public string Token { get; set; }
        public IList<string> Roles { get; set; }
        public List<RolePermissionModel> RolePermissionModelList { get; set; }
        public IList<ApproveRejectPermissionModel> ApproveRejectPermissionsInRole { get; set; }
        public IList<AgreeDisagreePermissionModel> AgreeDisagreePermissionsInRole { get; set; }
        public IList<OrderSchedulePermissionModel> OrderSchedulePermissionsInRole { get; set; }
        public List<int> UserOfficeList { get; set; }

        public ChartOfAccountNew ChartOfAccountNewDetail { get; set; }
        public VoucherDetailEntityModel VoucherDetailEntity { get; set; }
        public bool IsVoucherVerified { get; set; }
        public List<ChartOfAccountNew> AllAccountList { get; set; }
        public List<VoucherTransactionsModel> VoucherTransactions { get; set; }
        public IList<VoucherDetailModel> VoucherDetailList { get; set; }
        public int TotalCount { get; set; }
        public bool IsExchangeRateVerified { get; set; }
        public List<ExchangeRateDetailViewModel> ExchangeRateDetailViewModelList { get; set; }
        public List<ChartOfAccountNew> MainLevelAccountList { get; set; }
        public dynamic ExchangeRateVerificationList { get; set; }
        public VoucherDetailModel VoucherDetail { get; set; }
        public long TotalExchangeRateCount { get; set; }
        public ClientDetailModel clientDetailsById { get; set; }
        public int jobListTotalCount { get; set; }
        public ClientDetails clientDetails { get; set; }
        public ICollection<ClientDetails> ClientDetails { get; set; }
        public ICollection<Category> Categories { get; set; }



    }


    public class ItemAmount
    {
        public int ProcuredAmount { get; set; }
        public int SpentAmount { get; set; }
        public int CurrentAmount { get; set; }
    }

    public class LoggerDetailsModel
    {
        public int LoggerDetailsId { get; set; }
        public int NotificationId { get; set; }
        public bool IsRead { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string LoggedDetail { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string NotificationPath { get; set; }
    }

    //Get common Id for Project
    public class CommonId
    {
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public long LongId { get; set; }
    }
    //get Approval Value
}
