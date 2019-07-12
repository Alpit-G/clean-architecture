using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Commands.Delete
{
    public class DeleteChartOfAccountQuery : BaseModel, IRequest<ApiResponse>
    {
        public long AccountId { get; set; }
    }
}