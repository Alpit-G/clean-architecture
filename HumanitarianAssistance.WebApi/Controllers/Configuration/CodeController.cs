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
        #region "Created by Arjun Singh"
        [HttpPost]
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
        [HttpPost]
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

        [HttpPost]
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

        [HttpPost]
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

        [HttpPost]
        public async Task<ApiResponse> ApproveEmployeeInterviewRequest([FromQuery] int InterviewDetailsId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new ApproveEmployeeInterviewRequestCommand
            {
                InterviewDetailsId = InterviewDetailsId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        [HttpPost]
        public async Task<ApiResponse> RejectEmployeeInterviewRequest([FromQuery] int InterviewDetailsId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new RejectEmployeeInterviewRequestCommand
            {
                InterviewDetailsId = InterviewDetailsId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

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

        [HttpPost]
        public async Task<ApiResponse> GetEmployeeDetailByOfficeId([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetEmployeeDetailByOfficeIdQuery { OfficeId = OfficeId });
        }
        [HttpPost]
        public async Task<ApiResponse> GetEmployeeDetailByEmployeeId([FromQuery] int EmployeeId)
        {
            return await _mediator.Send(new GetEmployeeDetailByEmployeeIdQuery { EmployeeId = EmployeeId });
        }

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
        [HttpPost]
        public async Task<ApiResponse> GetAllInterviewTechnicalQuestionsByOfficeId([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetAllInterviewTechnicalQuestionsByOfficeIdQuery { OfficeId = OfficeId });
        }
        [HttpPost]
        public async Task<ApiResponse> AddExitInterview([FromBody]AddExitInterviewCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditExitInterview([FromBody]EditExitInterviewCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> DeleteExitInterview([FromQuery] int existInterviewDetailsId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new DeleteExitInterviewCommand
            {
                existInterviewDetailsId = existInterviewDetailsId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllExitInterview()
        {
            return await _mediator.Send(new GetAllExitInterviewQuery());
        }
        [HttpPost]
        public async Task<ApiResponse> GetSalaryTaxReportContentDetails(int OfficeId)
        {
            return await _mediator.Send(new GetSalaryTaxReportContentDetailsQuery { OfficeId = OfficeId });
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
        [HttpPost]
        public async Task<ApiResponse> GetEmployeeAdvanceHistoryDetail(long AdvanceID)
        {
            return await _mediator.Send(new GetEmployeeAdvanceHistoryDetailQuery { AdvanceID = AdvanceID });
        }
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
        [HttpGet]
        [AllowAnonymous]
        public async Task<ApiResponse> GetApplicationPages()
        {
            return await _mediator.Send(new GetApplicationPagesQuery());
        }

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
        public async Task<object> DeleteOfficeDetails([FromBody] DeleteOfficeDetailCommand model)
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

        [HttpPost]
        public async Task<object> AddCurrency([FromBody] AddCurrencyCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<object> EditCurrency([FromBody] EditCurrencyCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<object> GetAllCurrency()
        {
            return await _mediator.Send(new GetAllCurrencyQuery());
        }

        [HttpGet]
        public async Task<object> GetCurrencyByCurrencyCode(string CurrencyCode)
        {
            return await _mediator.Send(new GetCurrencyByCurrencyCodeQuery { CurrencyCode = CurrencyCode });
        }

        [HttpPost]
        public async Task<object> AddJournalDetail([FromBody] AddJournalDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<object> EditJournalDetail([FromBody] EditJournalDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<object> DeleteJournalDetail([FromBody] DeleteJournalDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<object> GetAllJournalDetail()
        {
            return await _mediator.Send(new GetAllCurrencyQuery());
        }

        //Email Setting Details Module Controller
        [HttpGet]
        public async Task<object> GetAllEmailSettingDetail()
        {
            return await _mediator.Send(new GetAllCurrencyQuery());
        }

        [HttpPost]
        public async Task<object> AddEmailSettingDetail([FromBody] AddEmailSettingCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<object> EditEmailSettingDetail([FromBody] EditEmailSettingCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<object> GetAllEmailType()
        {
            return await _mediator.Send(new GetAllEmailTypeQuery());
        }

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
        public async Task<object> GetAllAccountTypeByCategory([FromBody]int id)
        {
            return await _mediator.Send(new GetAllAccountTypeByCategoryQuery());
        }

        [HttpPost]
        public async Task<object> AddDesignation([FromBody] AddDesignationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<object> EditDesignation([FromBody] EditDesignationCommand model)
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

        [HttpGet]
        public async Task<ApiResponse> GetAllEmployeeAppraisalDetailsByEmployeeId([FromQuery] int EmployeeId, DateTime CurrentAppraisalDate)
        {
            return await _mediator.Send(new GetEmployeeAppraisalByIdQuery { EmployeeId = EmployeeId, CurrentAppraisalDate = CurrentAppraisalDate });
        }

        [HttpGet]
        public async Task<object> GetAllEmployeeAppraisalDetails([FromQuery] int OfficeId)
        {
            return await _mediator.Send(new GetEmployeeAppraisalDetailQuery { OfficeId = OfficeId });
        }

        [HttpPost]
        public async Task<object> EditEmployeeAppraisalDetails([FromBody] EditEmployeeAppraisalDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<object> AddEmployeeAppraisalDetails([FromBody] AddEmployeeAppraisalCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<object> GetAppraisalQuestions()
        {
            return await _mediator.Send(new GetAppraisalQuestionsQuery());
        }

        [HttpPost]
        public async Task<object> EditAppraisalQuestion([FromBody] EditAppraisalQuestionCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<object> AddAppraisalQuestion([FromBody] AddAppraisalQuestionCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<object> EditPensionRate([FromBody] EditPensionRateCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<object> AddPensionRate([FromBody] AddPensionRateCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }































































































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