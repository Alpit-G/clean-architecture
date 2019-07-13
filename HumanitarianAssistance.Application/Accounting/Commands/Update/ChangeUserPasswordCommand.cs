using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Commands.Update
{
    public class ChangeUserPasswordCommand : BaseModel, IRequest<ApiResponse>
    {
        public string Username { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string AspNetUserId { get; set; }

    }
}