using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Collections.Generic;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Enums;
using HumanitarianAssistance.Application.Configuration.Commands.Common;
using HumanitarianAssistance.Application.Configuration.Commands.Create;
using HumanitarianAssistance.Application.Configuration.Commands.Update;
using HumanitarianAssistance.Application.Configuration.Queries;
using HumanitarianAssistance.Application.Configuration.Commands.Delete;
using HumanitarianAssistance.Application.Accounting.Models;

namespace HumanitarianAssistance.WebApi.Controllers.Configuration
{
    [Produces("application/json")]
    [Route("api/Code/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Configuration))]
    [Authorize]
    public class CodeController : BaseController
    {

        #region "Office detail"

        [HttpPost]
        public async Task<ApiResponse> AddOfficeDetail([FromBody]AddOfficeDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);

        }

        [HttpPost]
        public async Task<ApiResponse> EditOfficeDetails([FromBody]EditOfficeDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteOfficeDetails([FromBody] DeleteOfficeDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllOfficeDetails()
        {
            return await _mediator.Send(new GetAllOfficeDetailQuery());
        }
        #endregion

        #region "Currency Detail"
        [HttpPost]
        public async Task<ApiResponse> AddCurrency([FromBody] AddCurrencyCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditCurrency([FromBody] EditCurrencyCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllCurrency()
        {
            return await _mediator.Send(new GetAllCurrencyQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetCurrencyByCurrencyCode(string CurrencyCode)
        {
            return await _mediator.Send(new GetCurrencyByCurrencyCodeQuery { CurrencyCode = CurrencyCode });
        }
        #endregion

        #region "Journal detail"
        [HttpPost]
        public async Task<ApiResponse> AddJournalDetail([FromBody] AddJournalDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditJournalDetail([FromBody] EditJournalDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteJournalDetail([FromBody] DeleteJournalDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllJournalDetail()
        {
            return await _mediator.Send(new GetAllJournalQuery());
        }

        #endregion

        #region "Email detail"
        //Email Setting Details Module Controller
        [HttpGet]
        public async Task<ApiResponse> GetAllEmailSettingDetail()
        {
            return await _mediator.Send(new GetAllEmailSettingQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> AddEmailSettingDetail([FromBody] AddEmailSettingCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditEmailSettingDetail([FromBody] EditEmailSettingCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllEmailType()
        {
            return await _mediator.Send(new GetAllEmailTypeQuery());
        }


        #endregion

        #region "Account type detail"
        [HttpPost]

        public async Task<ApiResponse> AddAccountType([FromBody]AddAccountTypeCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditAccountType([FromBody]EditAccountTypeCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllAccountTypeByCategory([FromBody]int id)
        {
            return await _mediator.Send(new GetAllAccountTypeByCategoryQuery());
        }


        #endregion

        #region "Designation detail"
        [HttpPost]
        public async Task<ApiResponse> AddDesignation([FromBody] AddDesignationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditDesignation([FromBody] EditDesignationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllDesignation()
        {
            return await _mediator.Send(new GetAllAccountTypeByCategoryQuery());
        }

        #endregion

        #region "Employee appraisal detail"

        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeAppraisalDetailsByEmployeeId([FromQuery] int EmployeeId, DateTime CurrentAppraisalDate)
        {
            return await _mediator.Send(new GetEmployeeAppraisalByIdQuery { EmployeeId = EmployeeId, CurrentAppraisalDate = CurrentAppraisalDate });
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeAppraisalDetails([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetEmployeeAppraisalDetailQuery { OfficeId = OfficeId });
        }

        [HttpPost]
        public async Task<ApiResponse> EditEmployeeAppraisalDetails([FromBody] EditEmployeeAppraisalDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> AddEmployeeAppraisalDetails([FromBody] AddEmployeeAppraisalCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }


        #endregion

        #region "Appraisal question detail"
        [HttpGet]
        public async Task<ApiResponse> GetAppraisalQuestions()
        {
            return await _mediator.Send(new GetAppraisalQuestionsQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> EditAppraisalQuestion([FromBody] EditAppraisalQuestionCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> AddAppraisalQuestion([FromBody] AddAppraisalQuestionCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }




        #endregion

        #region "Pension detail"
        [HttpPost]
        public async Task<ApiResponse> AddPensionRate([FromBody] AddPensionRateCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditPensionRate([FromBody] EditPensionRateCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }
        [HttpGet]
        public async Task<ApiResponse> GetAllPensionRate()
        {
            return await _mediator.Send(new GetAllPensionRateQuery());
        }

        #endregion

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
        public async Task<ApiResponse> EditFinancialYearDetail([FromBody]EditFinancialYearDetailCommand command)
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

        #region"Budget Line type detail"
        [HttpGet]
        public async Task<ApiResponse> GetBudgetLineTypes()
        {
            return await _mediator.Send(new GetBudgetLineTypesQuery());
        }
        #endregion

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
        public async Task<ApiResponse> EditQualifactionDetails([FromBody]EditQualificationDetailsCommand command)
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
        public async Task<ApiResponse> DeleteSalaryHead([FromBody]DeleteSalaryHeadCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(model);

        }


        [HttpGet]
        public async Task<ApiResponse> GetAllSalaryHead()
        {
            return await _mediator.Send(new GetAllSalaryHeadQuery());
        }
        #endregion

        #region "approve /reject appraisal question details"
        [HttpGet]
        public async Task<ApiResponse> ApproveEmployeeAppraisalRequest([FromQuery] int EmployeeAppraisalDetailsId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new ApproveEmployeeAppraisalRequestCommand
            {
                EmployeeAppraisalDetailsId = EmployeeAppraisalDetailsId,
                CreatedById = userId,
                CreatedDate = DateTime.UtcNow,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }
        [HttpGet]
        public async Task<ApiResponse> RejectEmployeeAppraisalRequest([FromQuery] int EmployeeAppraisalDetailsId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new RejectEmployeeAppraisalRequestCommand
            {
                EmployeeAppraisalDetailsId = EmployeeAppraisalDetailsId,
                CreatedById = userId,
                CreatedDate = DateTime.UtcNow,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        [HttpGet]
        public async Task<ApiResponse> ApproveEmployeeEvaluationRequest([FromQuery] int EmployeeEvaluationId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new ApproveEmployeeEvaluationRequestCommand
            {
                EmployeeEvaluationId = EmployeeEvaluationId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        [HttpGet]
        public async Task<ApiResponse> RejectEmployeeEvaluationRequest([FromQuery] int EmployeeEvaluationId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new RejectEmployeeEvaluationRequestCommand
            {
                EmployeeEvaluationId = EmployeeEvaluationId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }
        
        #endregion

        #region "Employee Appraisal More Details"
        [HttpPost]
        public async Task<ApiResponse> AddEmployeeAppraisalMoreDetails([FromBody]AddEmployeeAppraisalMoreDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditEmployeeAppraisalMoreDetails([FromBody]EditEmployeeAppraisalMoreDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> GetAllEmployeeAppraisalMoreDetails([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetAllEmployeeAppraisalMoreDetailsQuery { OfficeId = OfficeId });
        }
        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeList()
        {
            return await _mediator.Send(new GetAllEmployeeListQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetEmployeeDetailByOfficeId([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetEmployeeDetailByOfficeIdQuery { OfficeId = OfficeId });
        }
        [HttpGet]
        public async Task<ApiResponse> GetEmployeeDetailByEmployeeId([FromQuery] int EmployeeId)
        {
            return await _mediator.Send(new GetEmployeeDetailByEmployeeIdQuery { EmployeeId = EmployeeId });
        }

        #endregion

        #region "Interview Technical Questions"
        [HttpPost]
        public async Task<ApiResponse> AddInterviewTechnicalQuestions([FromBody]AddInterviewTechnicalQuestionsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditInterviewTechnicalQuestions([FromBody]EditInterviewTechnicalQuestionsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpGet]
        public async Task<ApiResponse> GetAllInterviewTechnicalQuestionsByOfficeId([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetAllInterviewTechnicalQuestionsByOfficeIdQuery { OfficeId = OfficeId });
        }
        #endregion

        #region "Salary Tax Report Details"
        [HttpGet]
        public async Task<ApiResponse> GetSalaryTaxReportContentDetails(int officeId)
        {
            return await _mediator.Send(new GetSalaryTaxReportContentDetailsQuery { OfficeId = officeId });
        }
        [HttpPost]
        public async Task<ApiResponse> AddSalaryTaxReportContentDetails([FromBody]AddSalaryTaxReportContentDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditSalaryTaxReportContentDetails([FromBody]EditSalaryTaxReportContentDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        #endregion

        #region "Payload head detail"
        [HttpGet]
        public async Task<ApiResponse> GetAllPayrollHead()
        {
            return await _mediator.Send(new GetAllPayrollHeadQuery());
        }
        [HttpPost]
        public async Task<ApiResponse> AddPayrollAccountHead([FromBody]AddPayrollAccountHeadCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> UpdatePayrollAccountHead([FromBody]UpdatePayrollAccountHeadCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> DeletePayrollAccountHead([FromBody]DeletePayrollAccountHeadCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }


        [HttpPost]
        public async Task<ApiResponse> GetAllDistrictDetailByProvinceId([FromBody] List<int?> ProvinceId)
        {
            return await _mediator.Send(new GetAllDistrictDetailByProvinceIdQuery { ProvinceId = ProvinceId });
        }

        //need to change later now this is only implemented to test
        [HttpPost]
        public async Task<ApiResponse> UpdatePayrollAccountHeadAllEmployees([FromBody] List<PayrollHeadModel> model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new UpdatePayrollAccountHeadAllEmployeesCommand
            {
                PayrollHead = model,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }
        [HttpPost]
        public async Task<ApiResponse> GetAllAccountByAccountHeadTypeId([FromBody]int id)
        {
            return await _mediator.Send(new GetAllAccountByAccountHeadTypeIdQuery { Id = id });
        }

        #endregion

        #region"Application page details"
        [HttpGet]
        [AllowAnonymous]
        public async Task<ApiResponse> GetApplicationPages()
        {
            return await _mediator.Send(new GetApplicationPagesQuery());
        }

        #endregion

        #region "Pension debit amount detail"
        [HttpPost]
        public async Task<ApiResponse> AddEditPensionDebitAccount([FromBody]long accountId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new AddEditPensionDebitAccountCommand
            {
                accountId = accountId,
                CreatedById = userId,
                CreatedDate = DateTime.UtcNow,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }
        [HttpGet]
        public async Task<ApiResponse> GetPensionDebitAccount()
        {
            return await _mediator.Send(new GetPensionDebitAccountQuery());
        }
        [HttpGet]
        public async Task<ApiResponse> GetAttendanceGroups()
        {
            return await _mediator.Send(new GetAttendanceGroupsQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> AddAttendanceGroups([FromBody]AddAttendanceGroupsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditAttendanceGroups([FromBody]EditAttendanceGroupsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        #endregion

        [HttpGet]
        public async Task<ApiResponse> GetAllLanguages()
        {
            return await _mediator.Send(new GetAttendanceGroupsQuery());
        }
        [HttpPost]
        public async Task<ApiResponse> AddJobGradeDetail([FromBody]AddJobGradeDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditJobGradeDetail([FromBody]EditJobGradeDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow; 
            return await _mediator.Send(command);
        }

    }
}