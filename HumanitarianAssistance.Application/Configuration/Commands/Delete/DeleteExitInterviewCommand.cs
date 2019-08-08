using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Configuration.Commands.Delete
{
    public class DeleteExitInterviewCommand : BaseModel, IRequest<ApiResponse>
    {
        public int existInterviewDetailsId { get; set; } 
    }
}
