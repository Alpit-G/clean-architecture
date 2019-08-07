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
            return await _mediator.Send(new GetAllProjectDetailsQuery());
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

            return await _mediator.Send(new GetAllProvinceDetailsQuery { CountryId= countryId });
        }
        #endregion

    }
}