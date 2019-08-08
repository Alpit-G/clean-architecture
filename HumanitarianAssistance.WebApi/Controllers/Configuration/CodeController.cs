using HumanitarianAssistance.Common.Enums;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HumanitarianAssistance.Application.Infrastructure;
using System;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Configuration.Queries;
using HumanitarianAssistance.Application.Configuration.Commands.Create;
using HumanitarianAssistance.Application.Configuration.Commands.Update;
using HumanitarianAssistance.Application.Configuration.Commands.Delete;

namespace HumanitarianAssistance.WebApi.Controllers.Configuration
{
    [Produces("application/json")]
    [Route("api/Code/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Configuration))]
    [Authorize]
    public class CodeController : BaseController
    {































































































        #region "GetProject Detail"

        [HttpGet]
        public async Task<ApiResponse> GetAllProjectDetails()
        {
            return await _mediator.Send(new GetAllProjectDetailsQuery());
        }

        #endregion

        #region "Profession Detail"

        [HttpPost]
        public async Task<ApiResponse> AddProfession([FromBody]AddProfessionCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditProfession([FromBody]EditProfessionCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllProfession()
        {
            return await _mediator.Send(new GetAllProfessionQuery());
        }
        #endregion

        #region "Country detail"
        [HttpGet]
        public async Task<ApiResponse> GetAllCountry()
        {
            return await _mediator.Send(new GetAllCountryQuery());
        }


        #endregion

        #region "GetAllProvinceDetails"
        [HttpGet]
        public async Task<ApiResponse> GetAllProvinceDetails([FromBody] int countryId)
        {

            return await _mediator.Send(new GetAllProvinceDetailsQuery { CountryId = countryId });
        }
        #endregion

        #region "GetAllQualification" 
        [HttpGet]
        public async Task<ApiResponse> GetAllQualification()
        {
            return await _mediator.Send(new GetAllQualificationQuery());
        }

        #endregion

        #region "AddLeaveReasonDetail"
        [HttpPost]
        public async Task<ApiResponse> AddLeaveReasonDetail([FromBody]AddLeaveReasonDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllLeaveReasonList()
        {
            return await _mediator.Send(new GetAllLeaveReasonQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> EditLeaveReasonDetail([FromBody]EditLeaveReasonDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }


        #endregion

        #region  "Financial Year Detail"
        [HttpPost]
        public async Task<ApiResponse> AddFinancialYearDetail([FromBody]AddFinancialYearDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditFinancialYearDetail([FromBody]EditFinancialYearDetailCommnad command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllFinancialYearDetail()
        {
            return await _mediator.Send(new GetAllFinancialYearDetailQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetCurrentFinancialYear()
        {
            return await _mediator.Send(new GetCurrentFinancialYearQuery());
        }



        #endregion

        #region"GetAllEmployeeType"
        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeType()
        {
            return await _mediator.Send(new GetAllEmployeeTypeQuery());
        }

        #endregion


        [HttpGet]
        public async Task<ApiResponse> GetBudgetLineTypes()
        {
            return await _mediator.Send(new GetBudgetLineTypesQuery());
        }


        #region "GetDepartmentsByOfficeId"
        [HttpGet]
        public async Task<ApiResponse> GetDepartmentsByOfficeId(int officeId)
        {
            return await _mediator.Send(new GetDepartmentsByOfficeQuery
            {
                OfficeId = officeId
            });
        }

        [HttpPost]
        public async Task<ApiResponse> AddDepartment([FromBody]AddDepartmentCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }


        [HttpPost]
        public async Task<ApiResponse> EditDepartment([FromBody]EditDepartmentCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllDepartment()
        {
            return await _mediator.Send(new GetAllDepartmentQuery());
        }

        #endregion

        #region "Qualification detail"
        [HttpPost]
        public async Task<ApiResponse> AddQualificationDetails([FromBody]AddQualificationDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditQualifactionDetails([FromBody]EditQualifactionDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }


        [HttpPost]
        public async Task<ApiResponse> DeleteQualifactionDetails([FromBody] int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new DeleteQualifactionDetailsCommand
            {
                QualificationId = id,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }
        #endregion
        
        #region "AddSalary Head detail"
        [HttpPost]
        public async Task<ApiResponse> AddSalaryHead([FromBody]AddSalaryHeadCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditSalaryHead([FromBody]EditSalaryHeadCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }


        [HttpPost]
        public async Task<ApiResponse> DeleteSalaryHead([FromBody] int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new DeleteSalaryHeadCommand
            {
                SalaryHeadId = id,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }


        [HttpGet]
        public async Task<ApiResponse> GetAllSalaryHead()
        {
            return await _mediator.Send(new GetAllSalaryHeadQuery());
        }
        #endregion
        [HttpGet]
        public async Task<ApiResponse> GetAllPensionRate()
        {
            return await _mediator.Send(new GetAllPensionRateQuery());
        }
    }
}