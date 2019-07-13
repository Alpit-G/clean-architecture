using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HumanitarianAssistance.Application.Accounting.Commands.Common;
using HumanitarianAssistance.Application.Accounting.Commands.Create;
using HumanitarianAssistance.Application.Accounting.Commands.Update;
using HumanitarianAssistance.Application.Accounting.Queries;
using HumanitarianAssistance.Application.Infrastructure;

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

        [HttpPost]
        public async Task<ApiResponse> GetVoucherDetailByVoucherNo([FromBody] long id)
        {
            return await _mediator.Send(new GetVoucherDetailByVoucherNoQuery { VoucherId = id });
        }

        [HttpPost]
        public async Task<ApiResponse> AddVoucherDetail([FromBody] AddVoucherDetailCommand model)
        {
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditVoucherDetail([FromBody] EditVoucherDetailCommand model)
        {
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> VerifyVoucher([FromBody] long id)
        {
            return await _mediator.Send(new VerifyVoucherCommand { VoucherId = id });
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllTransactionsByVoucherId([FromBody] long id)
        {
            return await _mediator.Send(new GetAllTransactionsByVoucherIdQuery { VoucherId = id });
        }

        [HttpPost]
        public async Task<ApiResponse> AddEditTransactionList([FromBody] AddEditTransactionListCommand model)
        {
            return await _mediator.Send(model);
        }

    }
}