using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Project.Commands.Create;
using HumanitarianAssistance.Application.Project.Queries;
using HumanitarianAssistance.Common.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HumanitarianAssistance.WebApi.Controllers.Project
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/HiringRequestController/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Marketing))]
    public class HiringRequestController : Controller
    {
        private readonly IMediator _mediator;
        public HiringRequestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ApiResponse> GetProjectHiringRequestDetail([FromBody]GetallHiringRequestDetailQuery query)
        {
            return await _mediator.Send(query);
        }
        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeList()
        {
            return await _mediator.Send(new GetAllEmployeeListQuery());
        } 
        [HttpPost]
        public async Task<ApiResponse> GetHiringCandidatesListById([FromBody]GetAllCandidateListQuery query)
        {
            return await _mediator.Send(query); 
        }
        [HttpPost]
        public async Task<ApiResponse> AddHiringRequestDetail([FromBody]AddProjectHiringRequestCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
    }
}
