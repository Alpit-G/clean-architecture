using HumanitarianAssistance.Common.Enums;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HumanitarianAssistance.Application.Infrastructure;
using System;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Configuration.Commands.Create;
using HumanitarianAssistance.Application.Configuration.Commands.Update;
using HumanitarianAssistance.Application.Configuration.Commands.Delete;
using HumanitarianAssistance.Application.Configuration.Queries;

namespace HumanitarianAssistance.WebApi.Controllers.Configuration
{
    [Produces("application/json")]
    [Route("api/Code/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Configuration))]
    [Authorize]
    public class CodeController : BaseController
    {


































































































































































































































































































































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
    }
}