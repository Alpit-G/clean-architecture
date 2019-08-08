using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HumanitarianAssistance.Common.Enums;

namespace HumanitarianAssistance.WebApi.Controllers.Store
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/Store/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Store))]
    [Authorize]
    public class StoreController : BaseController
    {


    }
}
