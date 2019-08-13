using HumanitarianAssistance.Application.HR.Commands.Create;
using HumanitarianAssistance.Application.HR.Commands.Update;
using HumanitarianAssistance.Application.HR.Queries;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;


namespace HumanitarianAssistance.WebApi.Controllers.HR
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/EmployeeHolidays/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Hr))]
    [Authorize]
    public class EmployeeHolidaysController : BaseController 
    {
        [HttpGet]
        public async Task<ApiResponse> GetAllHolidayDetails(int OfficeId)
        {
            return await _mediator.Send(new GetAllHolidayDetailsQuery { OfficeId = OfficeId });
        }
    }   
}
