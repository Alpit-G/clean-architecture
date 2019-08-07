using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using HumanitarianAssistance.Common.Helpers;
using System.Collections.Generic;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Enums;
using System.Linq;
using HumanitarianAssistance.Application.Configuration.Commands.Common;
using HumanitarianAssistance.Application.Configuration.Commands.Create;
using HumanitarianAssistance.Application.Configuration.Commands.Update;
using HumanitarianAssistance.Application.Configuration.Queries;

namespace HumanitarianAssistance.WebApi.Controllers.Configuration
{
    [Produces("application/json")]
    [Route("api/Code/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Configuration))]
    [Authorize]
    public class CodeController : BaseController
    {
        [HttpPost]
        public async Task<ApiResponse> ApproveEmployeeAppraisalRequest([FromQuery] int EmployeeAppraisalDetailsId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new ApproveEmployeeAppraisalRequestCommand
            {
                EmployeeAppraisalDetailsId = EmployeeAppraisalDetailsId,
                CreatedById = userId,
                CreatedDate = DateTime.UtcNow,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            }); 
        }
        [HttpPost]
        public async Task<ApiResponse> RejectEmployeeAppraisalRequest([FromQuery] int EmployeeAppraisalDetailsId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new RejectEmployeeAppraisalRequestCommand
            {
                EmployeeAppraisalDetailsId = EmployeeAppraisalDetailsId, 
                CreatedById = userId,
                CreatedDate = DateTime.UtcNow,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            }); 
        }

        [HttpPost]
        public async Task<ApiResponse> ApproveEmployeeEvaluationRequest([FromQuery] int EmployeeEvaluationId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new ApproveEmployeeEvaluationRequestCommand 
            {
                EmployeeEvaluationId = EmployeeEvaluationId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        [HttpPost]
        public async Task<ApiResponse> RejectEmployeeEvaluationRequest([FromQuery] int EmployeeEvaluationId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value; 
            return await _mediator.Send(new RejectEmployeeEvaluationRequestCommand
            {
                EmployeeEvaluationId = EmployeeEvaluationId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        [HttpPost]
        public async Task<ApiResponse> ApproveEmployeeInterviewRequest([FromQuery] int InterviewDetailsId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value; 
            return await _mediator.Send(new ApproveEmployeeInterviewRequestCommand
            {
                InterviewDetailsId = InterviewDetailsId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        [HttpPost]
        public async Task<ApiResponse> RejectEmployeeInterviewRequest([FromQuery] int InterviewDetailsId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new RejectEmployeeInterviewRequestCommand
            {
                InterviewDetailsId = InterviewDetailsId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        [HttpPost]
        public async Task<ApiResponse> AddEmployeeAppraisalMoreDetails([FromBody]AddEmployeeAppraisalMoreDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditEmployeeAppraisalMoreDetails([FromBody]EditEmployeeAppraisalMoreDetailsCommand command) 
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow; 
            return await _mediator.Send(command); 
        }
        [HttpPost]
        public async Task<ApiResponse> GetAllEmployeeAppraisalMoreDetails([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetAllEmployeeAppraisalMoreDetailsQuery { OfficeId = OfficeId });
        }
        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeList()
        {
            return await _mediator.Send(new GetAllEmployeeListQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> GetEmployeeDetailByOfficeId([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetEmployeeDetailByOfficeIdQuery { OfficeId = OfficeId }); 
        }
        [HttpPost]
        public async Task<ApiResponse> GetEmployeeDetailByEmployeeId([FromQuery] int EmployeeId)
        {
            return await _mediator.Send(new GetEmployeeDetailByEmployeeIdQuery { EmployeeId = EmployeeId });
        }
        
       [HttpPost]
        public async Task<ApiResponse> AddInterviewTechnicalQuestions([FromBody]AddInterviewTechnicalQuestionsCommand command) 
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;  
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditInterviewTechnicalQuestions([FromBody]EditInterviewTechnicalQuestionsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command); 
        }
        [HttpPost]
        public async Task<ApiResponse> GetAllInterviewTechnicalQuestionsByOfficeId([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetAllInterviewTechnicalQuestionsByOfficeIdQuery { OfficeId = OfficeId }); 
        }
        [HttpPost]
        public async Task<ApiResponse> AddExitInterview([FromBody]AddExitInterviewCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command); 
        }
    }    
}




