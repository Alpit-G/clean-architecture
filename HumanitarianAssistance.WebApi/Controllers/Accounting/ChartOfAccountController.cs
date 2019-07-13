﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Accounting.Commands.Create;
using HumanitarianAssistance.Application.Accounting.Commands.Delete;
using HumanitarianAssistance.Application.Accounting.Commands.Update;
using HumanitarianAssistance.Application.Accounting.Queries;
using HumanitarianAssistance.Application.Infrastructure;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System;

namespace HumanitarianAssistance.WebApi.Controllers.Accounting
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/ChartOfAccount/[Action]")]
    [Authorize]
    public class ChartOfAccountController : Controller
    {
        private readonly IMediator _mediator;

        public ChartOfAccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ApiResponse> GetMainLevelAccount([FromBody]long id)
        {
            return await _mediator.Send(new GetMainLevelAccountQuery { Id = id });
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllAccountsByParentId([FromBody]int id)
        {
            return await _mediator.Send(new GetAllAccountsByParentIdQuery { ParentId = id });
        }

        [HttpPost]
        public async Task<ApiResponse> AddChartOfAccount([FromBody]AddChartOfAccountCommand model)
        {
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditChartOfAccount([FromBody]EditChartOfAccountCommand model)
        {
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteChartOfAccount([FromBody]long accountId)
        {
            // var user = await _userManager.FindByNameAsync(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return await _mediator.Send(new DeleteChartOfAccountCommand
            {
                AccountId = accountId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

    }
}