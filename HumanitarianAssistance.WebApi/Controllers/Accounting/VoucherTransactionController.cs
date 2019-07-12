using System.Threading.Tasks;
using HumanitarianAssistance.Application.Accounting.Queries;
using HumanitarianAssistance.Application.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HumanitarianAssistance.WebApi.Controllers.Accounting
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/VoucherTransaction/[Action]")]
    public class VoucherTransactionController : Controller
    {
        private readonly IMediator _mediator;

        public VoucherTransactionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllVoucherList([FromBody]GetAllVoucherListQuery model)
        {
            return await _mediator.Send(model);
        }

    }
}