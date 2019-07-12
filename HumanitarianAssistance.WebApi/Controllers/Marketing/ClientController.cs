using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Marketing.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanitarianAssistance.WebApi.Controllers.Marketing
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/ChartOfAccount/[Action]")]
    public class ClientController : Controller
    {
        private readonly IMediator _mediator;
        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost] 
        public async Task<ApiResponse> GetClientsPaginatedList([FromBody]GetClientsPaginatedListQuery query)
        {
            return await _mediator.Send(query);
        }
        [HttpPost]
        public async Task<ApiResponse> GetClientDetailsById([FromBody]GetClientDetailsByIdQuery query)
        {
            return await _mediator.Send(query);
        }
        [HttpPost]
        public async Task<ApiResponse> GetAllClientList([FromBody]GetAllClientQuery query)
        {
            return await _mediator.Send(query);
        }

    }
}
