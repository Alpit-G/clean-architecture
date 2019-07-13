using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        // [HttpPost]
        // [AllowAnonymous]
        // public async Task<ApiResponse> Login([FromBody]LoginUserModel model)
        // {
        //     return await _mediator.Send(new GetMainLevelAccountQuery { Id = id });
        // }


    }
}