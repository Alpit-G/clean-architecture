using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using HumanitarianAssistance.Common.Helpers;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using HumanitarianAssistance.Domain.Entities;
using MediatR;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Project.Queries;
using HumanitarianAssistance.Application.Project.Commands.Create;
using HumanitarianAssistance.Application.Project.Commands.Delete;
using HumanitarianAssistance.Application.Project.Commands.Update;
using HumanitarianAssistance.Application.Project.Commands.Common;

namespace HumanitarianAssistance.WebApi.Controllers.Project
{
    [Produces("application/json")]
    [Route("api/Project/[Action]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProjectController : Controller
    {

        private readonly JsonSerializerSettings _serializerSettings;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMediator _mediator;
        private IHostingEnvironment _hostingEnvironment;
        public ProjectController(
           UserManager<AppUser> userManager,
          IHostingEnvironment hostingEnvironment,
          IMediator mediator
          )
        {
            _userManager = userManager;
            _hostingEnvironment = hostingEnvironment;
            _mediator = mediator;
            _serializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        #region Donor Details
        [HttpPost]
        public async Task<ApiResponse> GetAllDonorFilterList([FromBody]GetAllDonorFilterListQuery model)
        {
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllDonorList()
        {
            return await _mediator.Send(new GetAllDonorListQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditDonorDetails([FromBody]AddEditDonorDetailsCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteDonorDetails([FromBody]long DonarId)
        {
            DeleteDonorDetailCommand model = new DeleteDonorDetailCommand();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.DonorId = DonarId;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> GetDonarListById([FromBody]long DonarId)
        {
            return await _mediator.Send(new GetDonarListByIdQuery { DonorId = DonarId });
        }
        #endregion

        #region Sector Information

        [HttpGet]
        public async Task<ApiResponse> GetAllSectorList()
        {
            return await _mediator.Send(new GetAllSectorListQuery { });
        }

        [HttpPost]
        public async Task<ApiResponse> AddSectorDetails([FromBody]AddSectorDetailsCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditSectorDetails([FromBody]EditSectorDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteSectorDetails([FromBody]DeleteSectorDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        #endregion

        #region Program Information
        [HttpGet]
        public async Task<ApiResponse> GetAllProgramList()
        {
            return await _mediator.Send(new GetAllProgramListQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> AddProgramDetails([FromBody]AddProgramDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditProgramDetails([FromBody]EditProgramDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteProgramDetails([FromBody]DeleteProgramDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        #endregion

        #region Area Details
        [HttpGet]
        public async Task<ApiResponse> GetAllAreaList()
        {
            return await _mediator.Send(new GetAllAreaListQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> AddAreaDetails([FromBody]AddAreaDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditAreaDetails([FromBody]EditAreaDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteAreaDetails([FromBody]DeleteAreaDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        #endregion

        #region GenderConsiderationList

        [HttpGet]
        public async Task<ApiResponse> GenderConsiderationList()
        {
            return await _mediator.Send(new GenderConsiderationListQuery());
        }

        #endregion

        #region StrengthConsiderationDetailList

        [HttpGet]
        public async Task<ApiResponse> StrengthConsiderationDetailList()
        {
            return await _mediator.Send(new StrengthConsiderationDetailListQuery());
        }

        #endregion

        #region SecurityDetailList
        [HttpGet]
        public async Task<ApiResponse> SecurityDetailList()
        {
            return await _mediator.Send(new GetSecurityDetailListQuery());
        }
        #endregion

        //arjun singh 02082019
        #region "Voucher summary reports"
        [HttpPost]
        public async Task<ApiResponse> GetProjectJobsByProjectIds([FromBody] List<long> projectIds)
        {
            return await _mediator.Send(new GetProjectJobsByMultipleProjectIdsQuery { projectIds = projectIds });
        }

        [HttpPost]
        public async Task<ApiResponse> GetProjectBudgetLinesByProjectJobIds([FromBody] List<long?> projectJobIds)
        {
            return await _mediator.Send(new GetBudgetLinesByMultipleProjectJobIdsQuery { projectJobIds = projectJobIds });
        }
        #endregion

        #region "Project sub activity"
        [HttpPost]
        public async Task<ApiResponse> GetProjectSubActivityDetail([FromBody]int projectId)
        {
            return await _mediator.Send(new GetProjectSubActivityDetailsQuery { projectId = projectId });
        }

        [HttpPost]
        public async Task<ApiResponse> AddProjectSubActivityDetail([FromBody]AddProjectSubActivityDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditProjectSubActivity([FromBody]EditProjectSubActivityDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> ProjectSubActivityIscomplete([FromBody]long activityId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return await _mediator.Send(new ProjectSubActivityIscompleteCommand
            {
                activityId = activityId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow,
            });
        }
        [HttpPost]
        public async Task<ApiResponse> StartProjectSubActivity([FromBody]long activityId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return await _mediator.Send(new StartProjectSubActivityCommand
            {
                activityId = activityId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow,
            });
        }
        [HttpPost]
        public async Task<ApiResponse> EndProjectSubActivity([FromBody]long activityId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return await _mediator.Send(new EndProjectSubActivityCommand
            {
                activityId = activityId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow,
            });
        }
        [HttpPost]
        public async Task<ApiResponse> GetProjectActivityDetailByActivityId([FromBody]long activityId)
        {
            return await _mediator.Send(new GetProjectActivityByActivityIdQuery { activityId = activityId });
        }
        #endregion

        #region"Project activity extension"

        [HttpPost]
        public async Task<ApiResponse> GetProjectActivityExtension([FromBody]long activityId)
        {
            return await _mediator.Send(new GetProjectActivityExtensionQuery { activityId = activityId });
        }
        [HttpPost]
        public async Task<ApiResponse> AddProjectActivityExtension([FromBody]AddProjectActivityExtensionCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditProjectActivityExtension([FromBody]EditProjectActivityExtensionCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> DeleteProjectActivityExtension([FromBody]long extensionId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return await _mediator.Send(new DeleteProjectActivityExtensionCommand
            {
                extensionId = extensionId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow,
            });
        }
        #endregion

        #region "Project activity monitoring"
        [HttpPost]
        public async Task<ApiResponse> AddProjectMonitoringReview([FromBody]AddProjectMonitoringReviewCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> GetProjectActivityAdvanceFilterList([FromBody]GetProjectActivityAdvanceFilterListQuery query)
        {
            return await _mediator.Send(query);
        }
        [HttpPost]
        public async Task<ApiResponse> GetProjectMonitoringList([FromBody]long activityId)
        {
            return await _mediator.Send(new GetProjectMonitoringListQuery { activityId = activityId });
        }
        [HttpPost]
        public async Task<ApiResponse> GetProjectMonitoringByMonitoringId([FromBody]int Id)
        {
            return await _mediator.Send(new GetProjectMonitoringByMonitoringIdQuery { Id = Id });
        }

        [HttpPost]
        public async Task<ApiResponse> EditProjectMonitoringByMonitoringId([FromBody]EditProjectMonitoringByMonitoringIdCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        #endregion

        #region "GetProjectProposalAmountSummary"

        [HttpPost]
        public async Task<ApiResponse> GetProjectProposalAmountSummary([FromBody]GetProjectProposalAmountSummaryQuery query)
        {
            return await _mediator.Send(query);
        }
        #endregion 

        #region "ProjectIndicators"
        [HttpPost]
        public async Task<ApiResponse> GetAllProjectIndicators([FromBody]GetAllProjectIndicatorsQuery query)
        {
            return await _mediator.Send(query);
        }
        [HttpPost]
        public async Task<ApiResponse> GetProjectIndicatorDetailById([FromBody]long indicatorId)
        {
            return await _mediator.Send(new GetProjectIndicatorDetailByIdQuery { indicatorId = indicatorId });
        }
        [HttpPost]
        public async Task<ApiResponse> AddProjectIndicator()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new AddProjectIndicatorCommand
            {
                CreatedById = userId,
                CreatedDate = DateTime.UtcNow,
            });
        }
        [HttpPost]
        public async Task<ApiResponse> EditProjectIndicator([FromBody]EditProjectIndicatorCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> GetProjectIndicatorQuestionsById([FromBody]long indicatorId)
        {
            return await _mediator.Send(new GetProjectIndicatorQuestionsByIdQuery { indicatorId = indicatorId });
        }

        #endregion

        #region "GetProjectProposalReport"
        [HttpPost]
        public async Task<ApiResponse> GetProjectProposalReport([FromBody]GetProjectProposalReportQuery query)
        {
            return await _mediator.Send(query);
        }

        #endregion

        #region "DeleteActivityDocument"

        [HttpPost]
        public async Task<ApiResponse> DeleteActivityDocument([FromBody]long activityDocumentId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return await _mediator.Send(new DeleteActivityDocumentCommand
            {
                activityDocumentId = activityDocumentId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow,
            });
        }
        #endregion

        //Ending code of arjun singh 02082019   

        #region "Criteria evaluation form 2nd Aug 2019" 
        #region add/edit
        [HttpPost]
        public async Task<ApiResponse> AddEditDonorCriteria([FromBody]AddEditDonorCriteriaCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditPurposeofInitiativeCriteria([FromBody]AddEditPurposeofInitiativeCriteriaCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }


        [HttpPost]
        public async Task<ApiResponse> AddEditEligibilityCriteriaDetail([FromBody]AddEditEligibilityCriteriaDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditFeasibilityCriteria([FromBody]AddEditFeasibilityCriteriaCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> AddEditPriorityCriteria([FromBody]AddEditPriorityCriteriaCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }


        [HttpPost]
        public async Task<ApiResponse> AddEditFinancialCriteria([FromBody]AddEditFinancialCriteriaCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditRiskCriteria([FromBody]AddEditFinancialCriteriaCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditTargetBeneficiary([FromBody]AddEditTargetBeneficiaryCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditFinancialProjectDetail([FromBody]AddEditFinancialProjectDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> AddPriorityOtherDetail([FromBody]AddPriorityOtherDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(command);
        }


        [HttpPost]
        public async Task<ApiResponse> EditPriorityOtherDetail([FromBody]EditPriorityOtherDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllPriorityOtherDetailList()
        {
            return await _mediator.Send(new GetAllPriorityOtherDetailQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllPriorityOtherDetailByProjectId([FromBody] long projectId)
        {
            return await _mediator.Send(new GetAllPriorityOtherDetailByProjectIdQuery { ProjectId = projectId });
        }

        [HttpPost]
        public async Task<ApiResponse> DeletePriorityDetails([FromBody]long priorityOtherDetailId)
        {
            DeletePriorityOtherDetailCommand model = new DeletePriorityOtherDetailCommand();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.PriorityOtherDetailId = priorityOtherDetailId;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        #endregion

        #region feasibility Expert detail
        [HttpGet]
        public async Task<ApiResponse> GetAllFeasibilityExpertDetailList()
        {
            return await _mediator.Send(new GetAllFeasibilityExpertDetailQuery());
        }


        [HttpGet]
        public async Task<ApiResponse> GetAllExpertDetailByProjectId([FromBody] long projectId)
        {
            return await _mediator.Send(new GetAllExpertDetailByProjectIdQuery { ProjectId = projectId });
        }


        [HttpPost]
        public async Task<ApiResponse> AddFeasibleExpertOtherDetail([FromBody]AddFeasibleExpertOtherDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditFeasibilityExpertDetail([FromBody]EditFeasibilityExpertDetailCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteFeasibilityExperrtDetails([FromBody]long expertOtherDetailId)
        {
            DeleteFeasibilityExperrtDetailsCommand model = new DeleteFeasibilityExperrtDetailsCommand();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ExpertOtherDetailId = expertOtherDetailId;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }
        
        #endregion
        #endregion
    }

}