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
            _mediator= mediator;
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
            DeleteDonorDetailCommand model= new DeleteDonorDetailCommand();

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.DonorId= DonarId;
            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;
            model.CreatedById = userId;
            model.CreatedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> GetDonarListById([FromBody]long DonarId)
        {
            return await _mediator.Send(new GetDonarListByIdQuery { DonorId= DonarId });
        }
    #endregion

        [HttpGet]
        public async Task<ApiResponse> GetAllSectorList()
        {
            return await _mediator.Send(new GetAllSectorListQuery { });
        }
    }
}