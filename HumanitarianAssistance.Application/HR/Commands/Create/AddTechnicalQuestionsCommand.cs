using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.HR.Commands.Create
{
    public class AddTechnicalQuestionsCommand : BaseModel, IRequest<ApiResponse>
    {
        public int InterviewTechnicalQuestionsId { get; set; }
        public string Question { get; set; }
        public int OfficeId { get; set; }
    }
}
