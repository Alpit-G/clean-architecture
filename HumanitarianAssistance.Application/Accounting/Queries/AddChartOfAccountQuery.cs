using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Queries
{
    public class AddChartOfAccountQuery : IRequest<ApiResponse>
    {
        public long ChartOfAccountNewId { get; set; }
        public string AccountName { get; set; }
        public string ChartOfAccountNewCode { get; set; }
        public long ParentID { get; set; }
        public int AccountLevelId { get; set; }
        public int AccountHeadTypeId { get; set; }
        public int? AccountTypeId { get; set; }
        public int? AccountFilterTypeId { get; set; }
    }
}