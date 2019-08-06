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

     #region SecurityConsiderationDetailList
        [HttpGet]
        public async Task<ApiResponse> SecurityConsiderationDetailList()
        {
            return await _mediator.Send(new SecurityConsiderationListQuery());
        }
     #endregion

    #region Project Details
        [HttpPost]
        public async Task<ApiResponse> AddEditProjectDetail([FromBody]AddEditProjectDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteProjectDetail([FromBody]long ProjectId)
        {
            DeleteProjectDetailCommand model= new DeleteProjectDetailCommand();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllProjectFilterList([FromBody]GetAllProjectFilterListQuery model)
        {
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> GetProjectListById([FromBody]long Id)
        {
            return await _mediator.Send(new GetProjectListByIdQuery{ Id= Id });
        }

        [HttpPost]
        public async Task<ApiResponse> GetProjectOtherDetailById([FromBody]long Id)
        {
            return await _mediator.Send(new GetProjectListByIdQuery{ Id= Id });
        }


    #endregion

     #region Add/Update Assign Employee to Project

        [HttpPost]
        public async Task<ApiResponse> AddEditProjectAssignToEmployee([FromBody]AddEditProjectAssignToEmployeeCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteProjectAssignToEmployee([FromBody]RemoveEmployeeFromAssignedProjectCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

     #endregion

     #region Add/Edit Project Program to Current Project

        [HttpPost]
        public async Task<ApiResponse> AddEditProjectProgram([FromBody]AddEditProjectProgramCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> getProjectProgramById([FromBody]long ProjectId)
        {
            return await _mediator.Send(new GetProjectProgramByIdQuery { ProjectId= ProjectId });
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditProjectArea([FromBody]AddEditProjectAreaCommand model)
        {
           var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> getProjectAreaById([FromBody]long ProjectId)
        {
            return await _mediator.Send(new GetProjectAreaByIdQuery { ProjectId= ProjectId });
        }

         [HttpPost]
        public async Task<ApiResponse> getProjectSectorById([FromBody]long ProjectId)
        {
            return await _mediator.Send(new GetProjectAreaByIdQuery { ProjectId= ProjectId });
        }

         [HttpPost]
        public async Task<ApiResponse> DeleteProjectProgram([FromBody]DeleteProjectProgramCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

     #endregion

     #region Add/Edit Project Sector Area to Current Project

        [HttpPost]
        public async Task<ApiResponse> AddEditProjectSector([FromBody]AddEditProjectSectorCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteProjectArea([FromBody]DeleteProjectAreaCommand model)
        {
           var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

     #endregion

     #region "GetProjectWinLossStatus"

        [HttpPost]
        public async Task<ApiResponse> GetProjectWinLossStatus([FromBody]long ProjectId)
        {
            return await _mediator.Send(new GetProjectWinLossStatusQuery { ProjectId= ProjectId });
        }

     #endregion

     #region Other Details dropdown

        [HttpGet]
        public async Task<ApiResponse> GetAllStrengthConsiderationDetails()
        {
           return await _mediator.Send(new GetAllStrengthConsiderationDetailsQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllGenderConsiderationDetails()
        {
            return await _mediator.Send(new GetAllGenderConsiderationQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllSecurityDetails()
        {
            return await _mediator.Send(new GetAllSecurityDetailQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllProvinceDetails()
        {
            return await _mediator.Send(new GetAllProvinceDetailQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllProvinceDetailsByCountryId([FromBody]int[] countryId)
        {

            return await _mediator.Send(new GetAllProvincesByCountryIdQuery { CountryId= countryId });
        }

        [HttpPost]
        public async Task<ApiResponse> GetCountryMultiSelectByProjectId([FromBody]long Id)
        {
            return await _mediator.Send(new GetCountryByProjectIdQuery { ProjectId= Id });
        }

        [HttpPost]
        public async Task<ApiResponse> GetProvinceMultiSelectByProjectId([FromBody]long Id)
        {
           return await _mediator.Send(new GetSelectedProvinceByProjectIdQuery { ProjectId= Id });
        }

        [HttpPost]
        public async Task<ApiResponse> GetDistrictMultiSelectByProjectId([FromBody]long Id)
        {
            return await _mediator.Send(new GetSelectedDistrictByProjectIdQuery { ProjectId= Id });
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditDistrictMultiselect([FromBody]AddEditSelectedDistrictsCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditCountryMultiselect([FromBody]AddEditCountryByProjectIdCommand model) 
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditProvinceMultiselect([FromBody]AddEditProvinceByProjectIdCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllDistrictvalueByProvinceId([FromBody]int[] ProvinceId)
        {
            return await _mediator.Send(new GetAllDistrictByProvinceIdQuery { ProvinceId= ProvinceId });
        }

         [HttpPost]
        public async Task<ApiResponse> AddEditProjectotherDetail([FromBody]AddEditProjectOtherDetailCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllSecurityConsiderationDetails()
        {
             return await _mediator.Send(new GetSecurityConsiderationDetailQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> GetSecurityConsiMultiSelectByProjectId([FromBody]long Id)
        {
             return await _mediator.Send(new GetSecurityConsiderationByProjectIdQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditSecurityConsiMultiselect([FromBody]AddEditSecurityConsiderationCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(model);
        }



     #endregion



     

        //arjun singh 02082019

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

        //Ending code of arjun singh 02082019
    }

}