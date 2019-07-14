using HumanitarianAssistance.Application.Accounting.Commands.Create;
using HumanitarianAssistance.Application.Accounting.Commands.Delete;
using HumanitarianAssistance.Application.Accounting.Queries;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Enums;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;   

namespace HumanitarianAssistance.WebApi.Controllers.Accounting
{
    [Produces("application/json")]
    [Route("api/GainLossReport/[Action]/")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Accounting))]
    [Authorize]
    public class GainLossReportController: Controller
    {
       private readonly IMediator _mediator; 

       public  GainLossReportController(IMediator mediator)
       {
            _mediator = mediator;
       }

        [HttpGet]
        public async Task<ApiResponse> GetExchangeGainLossFilterAccountList()
        {
            return await _mediator.Send(new GetExchangeGainLossFilterAccountListQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetExchangeGainLossVoucherList()
        {
            return await _mediator.Send(new GetExchangeGainLossVoucherListQuery());
        }

         [HttpPost]
        public async Task<ApiResponse> AddExchangeGainLossVoucher([FromBody] ExchangeGainLossVoucherDetailsCommand model)
        {
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteGainLossVoucherTransaction([FromBody]long id)
        {
            return await _mediator.Send(new DeleteGainLossVoucherTransactionCommand {VoucherNo=id});
        }

    }
}