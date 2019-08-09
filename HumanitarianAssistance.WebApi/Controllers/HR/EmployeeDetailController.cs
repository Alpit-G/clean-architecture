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

        #region "Employee History Outside Country"
        [HttpGet]

        public async Task<ApiResponse> GetAllEmployeeHistoryOutsideCountry([FromQuery]int EmployeeId)
        {
            return await _mediator.Send(new GetEmployeeHistoryOutsideOrganizationQuery { EmployeeId = EmployeeId });
        }

        [HttpPost]
        public async Task<ApiResponse> AddEmployeeHistoryOutsideCountry([FromBody]AddEmployeeHistoryOutsideCountryCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditEmployeeHistoryOutsideCountry([FromBody] EditEmployeeHistoryOutsideCountryCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteEmployeeHistoryOutsideCountry([FromBody]DeleteEmployeeHistoryOutsideCountryCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }


        #endregion

        #region "Employee Relative Information"

        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeRelativeInformation([FromQuery]int EmployeeId)
        {
            return await _mediator.Send(new GetAllEmployeeRelativeInformationQuery { EmployeeId = EmployeeId });
        }

        [HttpPost]
        public async Task<ApiResponse> AddEmployeeRelativeInformation([FromBody]AddEmployeeRelativeInformationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditEmployeeRelativeInformation([FromBody] EditEmployeeRelativeInformationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteEmployeeRelativeInformation([FromBody]DeleteEmployeeRelativeInformationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }
        #endregion
        #region "Employee Info References"
        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeInfoReferences([FromQuery]int EmployeeId)
        {
            return await _mediator.Send(new GetAllEmployeeInfoReferencesQuery { EmployeeId = EmployeeId });
        }

        [HttpPost]
        public async Task<ApiResponse> AddEmployeeInfoReferences([FromBody]AddEmployeeInfoReferencesCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditEmployeeInfoReferences([FromBody] EditEmployeeInfoReferencesCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }


        [HttpPost]
        public async Task<ApiResponse> DeleteEmployeeInfoReferences([FromBody]DeleteEmployeeInfoReferencesCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }
        #endregion

        #region "Employee Other Skills"
        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeOtherSkills([FromQuery]int EmployeeId)
        {
            return await _mediator.Send(new GetAllEmployeeOtherSkillsQuery { EmployeeId = EmployeeId });
        }

        [HttpPost]
        public async Task<ApiResponse> AddEmployeeOtherSkills([FromBody]AddEmployeeOtherSkillsCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditEmployeeOtherSkills([FromBody] EditEmployeeOtherSkillsCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteEmployeeOtherSkills([FromBody]DeleteEmployeeOtherSkillsCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        #endregion
        #region "Employee Salary Budgets"
        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeSalaryBudgets([FromQuery]int EmployeeId)
        {
            return await _mediator.Send(new GetAllEmployeeOtherSkillsQuery { EmployeeId = EmployeeId });
        }
        [HttpPost]
        public async Task<ApiResponse> AddEmployeeSalaryBudgets([FromBody]AddEmployeeSalaryBudgetsCommand model)
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