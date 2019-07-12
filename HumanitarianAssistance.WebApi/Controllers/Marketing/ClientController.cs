using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Marketing.Commands.Create;
using HumanitarianAssistance.Application.Marketing.Commands.Delete;
using HumanitarianAssistance.Application.Marketing.Commands.Update;
using HumanitarianAssistance.Application.Marketing.Models;
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
        public async Task<ApiResponse> GetClientDetailsById(int ClientId)
        {
            return await _mediator.Send(new GetClientDetailsByIdQuery { ClientId = ClientId });
        }
        [HttpPost]
        public async Task<ApiResponse> GetAllClientList()
        {
            return await _mediator.Send(new GetAllClientQuery());
        }
        [HttpPost]
        public async Task<ApiResponse> GetFilteredClientList([FromBody]FilterClientListQuery query)
        {
            return await _mediator.Send(query);
        }
        [HttpPost]
        public async Task<ApiResponse> GetAllCategoryList()
        {
            return await _mediator.Send(new GetAllCategoryQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> AddClient([FromBody]AddClientDetailsCommand command)
        {
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditClient([FromBody]EditClientDetailsCommand command)
        {
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> DeleteClient(int ClientId)
        {
            return await _mediator.Send(new DeleteClientDetailsCommand { ClientId = ClientId });
        }

        [HttpPost]
        public async Task<ApiResponse> AddCategory([FromBody]CategoryModel model)
        {
            if (model.CategoryId == 0)
            {
                return await _mediator.Send(new AddCategoryCommand {CategoryId=model.CategoryId,CategoryName=model.CategoryName });
            }
            else
            {
               return await _mediator.Send(new EditCategoryCommand { CategoryId = model.CategoryId, CategoryName = model.CategoryName });
            } 
        }

    }
}
