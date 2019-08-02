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
    }
}