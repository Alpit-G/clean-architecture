using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Accounting.Commands.Common;
using HumanitarianAssistance.Application.Accounting.Commands.Create;
using HumanitarianAssistance.Application.Accounting.Commands.Update;
using HumanitarianAssistance.Application.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HumanitarianAssistance.WebApi.Controllers.Accounting
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/Account/[Action]")]
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AccountController : Controller
    {

        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ApiResponse> Login([FromBody]LoginCommand model)
        {
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> AddUsers([FromBody]AddUserCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditUsers([FromBody]EditUsersCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> ChangePassword([FromBody]ChangeUserPasswordCommand model)
        {

            model.ModifiedById = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> ResetPassword([FromBody]ResetUserPasswordCommand model)
        {

            model.ModifiedById = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }




    }
}