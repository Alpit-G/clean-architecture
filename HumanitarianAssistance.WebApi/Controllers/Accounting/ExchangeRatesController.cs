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
        public ApiResponse GetSavedExchangeRates([FromBody] ExchangeRateVerificationFilter filter)
        {
            APIResponse response = _iExchangeRate.GetSavedExchangeRates(filter);
            return response;
        }
    }
}