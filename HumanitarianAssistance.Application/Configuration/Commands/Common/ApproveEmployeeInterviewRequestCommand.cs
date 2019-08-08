using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Configuration.Commands.Common
{
    public class ApproveEmployeeInterviewRequestCommand : BaseModel, IRequest<ApiResponse>
    {
        public int InterviewDetailsId { get; set; } 
    }
}
