using HumanitarianAssistance.Common.Enums;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HumanitarianAssistance.Application.Infrastructure;
using System;
using System.Threading.Tasks;

namespace HumanitarianAssistance.WebApi.Controllers.Configuration
{
    [Produces("application/json")]
    [Route("api/Code/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Configuration))]
    [Authorize]
    public class CodeController : BaseController
    {

        
    }
}