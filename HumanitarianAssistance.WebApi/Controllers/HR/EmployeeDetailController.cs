using System;
using System.Security.Claims;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.HR.Commands.Create;
using HumanitarianAssistance.Application.HR.Commands.Delete;
using HumanitarianAssistance.Application.HR.Commands.Update;
using HumanitarianAssistance.Application.HR.Queries;
using HumanitarianAssistance.Application.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HumanitarianAssistance.WebApi.Controllers.HR
{
    [Produces("application/json")]
    [Route("api/EmployeeDetail/[Action]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class EmployeeDetailController : BaseController
    {

        #region "Employee History Outside Organization"

        [HttpGet]

        public async Task<ApiResponse> GetAllEmployeeHistoryOutsideOrganization([FromQuery]int EmployeeId)
        {
            return await _mediator.Send(new GetEmployeeHistoryOutsideOrganizationQuery { EmployeeId = EmployeeId });
        }

        [HttpPost]
        public async Task<ApiResponse> AddEmployeeHistoryOutsideOrganization([FromBody]AddEmployeeHistoryOutsideOrganizationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditEmployeeHistoryOutsideOrganization([FromBody]EditEmployeeHistoryOutsideOrganizationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteEmployeeHistoryOutsideOrganization([FromBody]DeleteEmployeeHistoryOutsideOrganizationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }
        
        #endregion


    }
}