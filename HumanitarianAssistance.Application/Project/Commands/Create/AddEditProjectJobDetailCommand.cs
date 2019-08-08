using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Project.Commands.Create
{
    public class AddEditProjectJobDetailCommand : BaseModel, IRequest<ApiResponse>
    {
        public long ProjectJobId { get; set; }
        public string ProjectJobCode { get; set; }
        public string ProjectJobName { get; set; }
        public long ProjectId { get; set; }
    }
}
