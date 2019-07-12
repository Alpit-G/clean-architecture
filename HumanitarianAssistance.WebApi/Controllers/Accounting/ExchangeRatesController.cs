using System.Collections.Generic;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Accounting.Commands.Create;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Accounting.Queries;
using HumanitarianAssistance.Application.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HumanitarianAssistance.WebApi.Controllers.Accounting
{
    [Produces("application/json")]
    [Route("api/ExchangeRates/[Action]/")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ExchangeRatesController: Controller
    {
       private readonly IMediator _mediator; 

       public ExchangeRatesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ApiResponse> GetSavedExchangeRatesAsync([FromBody] GetSavedExchangeRatesQuery filter)
        {
             return await _mediator.Send(filter);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveSystemGeneratedExchangeRates([FromBody] List<AddExchangeRateModel> model)
        {
            AddExchangeRateCommand cs= new AddExchangeRateCommand();
            cs.AddExchangeRateList.AddRange(model);
            return await _mediator.Send(cs);
        }
    }
}