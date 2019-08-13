using HumanitarianAssistance.Application.HR.Commands.Create;
using HumanitarianAssistance.Application.HR.Commands.Update;
using HumanitarianAssistance.Application.HR.Models;
using HumanitarianAssistance.Application.HR.Queries;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;


namespace HumanitarianAssistance.WebApi.Controllers.HR
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/Interview/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Hr))]
    [Authorize]
    public class InterviewController : BaseController
    {
        [HttpPost]
        public async Task<ApiResponse> AddInterviewScheduleDetails([FromBody]List<InterviewScheduleModel> model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new AddInterviewScheduleDetailsCommand
            {
                InterViewSchedule = model,
                CreatedById = userId,
                CreatedDate = DateTime.UtcNow,
            });
        }
        [HttpPost]
        public async Task<ApiResponse> InterviewApprovals([FromBody] List<InterviewScheduleModel> model, int approvalId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new InterviewApprovalsCommand
            {
                InterViewSchedule = model,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow,
            });
        }
        [HttpPost]
        public async Task<ApiResponse> AddInterviewDetails([FromBody]AddInterviewDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId; 
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditInterviewDetails([FromBody]EditInterviewDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpGet]
        public async Task<ApiResponse> GetAllInterviewDetails()
        {
            return await _mediator.Send(new GetAllInterviewDetailsQuery()); 
        }

        //[HttpPost]
        //public async Task<ApiResponse> AddTechnicalQuestions([FromBody]AddTechnicalQuestionsCommand command)
        //{
        //    var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value; 
        //    command.CreatedById = userId;
        //    command.CreatedDate = DateTime.UtcNow;
        //    return await _mediator.Send(command);
        //}
    }   
}
