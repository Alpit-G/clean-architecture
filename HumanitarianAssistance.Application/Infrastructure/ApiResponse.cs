using System;
using System.Collections.Generic;
using System.Text;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Marketing.Models;
using HumanitarianAssistance.Application.Project.Models;
using HumanitarianAssistance.Domain.Entities;
using HumanitarianAssistance.Domain.Entities.Accounting;
using HumanitarianAssistance.Domain.Entities.Marketing;
using HumanitarianAssistance.Domain.Entities.Project;

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
        // public GainLossVoucherList GainLossVoucherDetail { get; set; }
        public dynamic GainLossVoucherList { get; set; }
        public dynamic AccountBalances { get; set; }
        public dynamic GainLossVoucherDetail { get; set; }
        // public List<NoteAccountBalances> NoteAccountBalances { get; set; }
        public dynamic NoteAccountBalances { get; set; }
        public dynamic GainLossSelectedAccounts { get; set; }
        public dynamic TrialBalanceList { get; set; }
        public dynamic VoucherSummaryTransactionList { get; set; }
        public List<Roles> RoleList { get; set; }
        public IList<UserDetailsModel> UserDetailsList { get; set; }
        public ICollection<UserDetails> UserDetailList { get; set; }
        public UserDetailsModel UserDetails { get; set; }
        public IList<PermissionsInRolesModel> PermissionsInRolesList { get; set; }
        public IList<PermissionsModel> PermissionsList { get; set; }
        public IList<VoucherTypeModel> VoucherTypeList { get; set; }
        public IList<AccountDetailModel> AccountDetailList { get; set; }
        public List<LoggerModel> LoggerDetailsModelList { get; set; }
        public string VoucherReferenceNo { get; set; }
        public long VoucherNo { get; set; }
        public List<AccountFilterType> AllAccountFilterList { get; set; }
        public List<ApplicationPages> ApplicationPagesList { get; set; }
        public IList<RolePermissionViewModel> PermissionsInRole { get; set; }





        // Marketing
        public byte[] pdf { get; set; }
        public dynamic contractDetailsModel { get; set; }
        public ICollection<JobPriceDetails> JobPriceDetails { get; set; }
        public JobPriceModel JobPriceDetail { get; set; }
        public ContractDetails contractDetails { get; set; }
        public ICollection<ContractDetails> ContractDetails { get; set; }
        public ActivityType activityById { get; set; }
        public ICollection<ActivityType> ActivityTypes { get; set; }
        public ICollection<LanguageDetail> Languages { get; set; }
        public ICollection<MediaCategory> MediaCategories { get; set; }
        public JobPhase phaseById { get; set; }
        public Channel channelById { get; set; }
        public ICollection<Channel> Channels { get; set; }
        public JobDetails JobDetailModel { get; set; }
        public ICollection<JobDetails> JobDetails { get; set; }
        public JobDetailsModel JobDetail { get; set; }
        public InvoiceModel invoiceDetails { get; set; }
        public List<JobDetailsModel> JobPriceDetailList { get; set; }
        public List<JobDetailsModel> JobDetailsModel { get; set; }
        public ICollection<Medium> Mediums { get; set; }
        public ICollection<JobPhase> JobPhases { get; set; }
        public UnitRate unitRateDetailsById { get; set; }
        public dynamic unitRateDetails { get; set; }
        public ICollection<Nature> Natures { get; set; }
        public ICollection<Quality> Qualities { get; set; }
        public List<UnitRateDetailsModel> UnitRateDetails { get; set; }
        public ICollection<TimeCategory> TimeCategories { get; set; }
        public List<ContractByClient> ContractByClientList { get; set; }
        public ICollection<CurrencyDetails> Currencies { get; set; }
        public ICollection<Producer> Producers { get; set; }
        public MediaCategory mediaCategoryById { get; set; }
        public Medium mediumById { get; set; }
        public Nature natureById { get; set; }
        public Quality qualityById { get; set; }
        public TimeCategory timeCatergoryById { get; set; }
        public UnitRate UnitRateByActivityId { get; set; }
        public UnitRateDetailsModel rateDetailsById { get; set; }
        public ICollection<UnitRate> UnitRates { get; set; }
        public PolicyDetail policyDetails { get; set; }
        public List<PolicyModel> policyList { get; set; }
        public List<PolicyModel> policyFilterList { get; set; }
        public PolicyModel policyDetailsById { get; set; }
        public List<PolicyScheduleModel> policySchedulesByDateList { get; set; }
        public PolicyTimeSchedule policyTimeScheduleDetails { get; set; }
        public List<PolicyTimeScheduleModel> policySchedulesByTimeList { get; set; }
        public PolicyTimeScheduleModel policyTimeDetailsById { get; set; }
        public PolicyDaySchedule policyDayScheduleDetails { get; set; }
        public Producer producerById { get; set; }
        public List<PolicyModel> PolicyFilteredList { get; set; }

        //Project
        public ICollection<DonorDetail> DonorDetail { get; set; }
        public DonorDetail DonorDetailById { get; set; }
        public ICollection<SectorDetails> sectorDetails { get; set; }
        public ICollection<ProgramDetail> programDetails { get; set; }
        public ProgramDetail ProgramDetail { get; set; }

        //Project
        public IList<ProjectHiringCandidateDetailModel> ProjectHiringCandidateDetailModel { get; set; }
        public List<EmployeeDetailListModel> EmployeeDetailListData { get; set; }
        public IList<ProjectHiringRequestModel> ProjectHiringRequestModel { get; set; }
        public List<OpportunityControlViewModel> OpportunityControlList { get; set; }
        public List<LogisticsControlViewModel> LogisticsControlList { get; set; }
        public List<ActivitiesControlViewModel> ActivitiesControlList { get; set; }
        public List<ProjectActivityPermissionModel> ProjectActivityPermissionList { get; set; }
        public List<HiringControlViewModel> HiringControlList { get; set; }
        public SectorDetails SectorDetails { get; set; }
        public ICollection<ProjectJobDetail> ProjectJobDetail { get; set; }
        public IList<ProjectBudgetLineDetailsModel> ProjectBudgetLineDetailList { get; set; }
        public ICollection<ProjectSubActivityListModel> ProjectSubActivityListModel { get; set; }
        public ProjectActivityModel ProjectActivityModel { get; set; }
        public ProjectActivityDetail ProjectActivityDetail { get; set; }
        public ProjectActivityModel ProjectActivityDetails { get; set; }
        public ICollection<ProjectActivityExtensions> ProjectActivityExtensionsList { get; set; }
        public ICollection<ProjectActivityModel> ProjectActivityList { get; set; }
        public List<ProjectMonitoringViewModel> ProjectMonitoring { get; set; }
        public ProjectMonitoringViewModel ProjectMonitoringModel { get; set; }
        public List<ProjectProposalAmountSummary> ProjectProposalAmountSummary { get; set; }
        public ProjectIndicatorModel ProjectIndicatorList { get; set; }
        public EditIndicatorModel IndicatorModel { get; set; }
        public ProjectIndicatorViewModel ProjectIndicator { get; set; }
        public List<IndicatorQuestions> Questions { get; set; }
        public List<SPProjectProposalReportModel> ProjectProposalReportList { get; set; }
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
