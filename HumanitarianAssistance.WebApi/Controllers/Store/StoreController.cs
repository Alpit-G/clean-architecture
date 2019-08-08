using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HumanitarianAssistance.Common.Enums;
using HumanitarianAssistance.Application.Infrastructure;
using System.Threading.Tasks;
using System.Security.Claims;
using System;
using HumanitarianAssistance.Application.Store.Commands.Create;
using HumanitarianAssistance.Application.Store.Commands.Update;
using HumanitarianAssistance.Application.Store.Commands.Delete;
using HumanitarianAssistance.Application.Store.Queries;
using System.Collections.Generic;
using HumanitarianAssistance.Application.Store.Models;

namespace HumanitarianAssistance.WebApi.Controllers.Store
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/Store/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Store))]
    [Authorize]
    public class StoreController : BaseController
    {
        #region "Store Order"

        [HttpPost]
        public async Task<ApiResponse> AddItemOrder([FromBody] AddItemOrderCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditItemOrder([FromBody] EditItemOrderCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> DeleteItemOrder([FromBody] DeleteItemOrderCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllItemsOrder(string ItemId)
        {
            return await _mediator.Send(new GetAllItemsOrderQuery
            {
                ItemId = ItemId
            });
        }

        #endregion

        #region "Purchase Unit Type"

        [HttpPost]
        public async Task<ApiResponse> AddPurchaseUnitType([FromBody]AddPurchaseUnitTypeCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditPurchaseUnitType([FromBody] EditPurchaseUnitTypeCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> DeletePurchaseUnitType([FromBody] DeletePurchaseUnitTypeCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }


        [HttpGet]
        public async Task<ApiResponse> GetAllPurchaseUnitType()
        {
            return await _mediator.Send(new GetAllPurchaseUnitTypeQuery());
        }

        #endregion

        #region "Others"

        [HttpGet]
        public async Task<ApiResponse> GetItemAmounts(string ItemId)
        {
            return await _mediator.Send(new GetItemAmountsQuery
            {
                ItemId = ItemId
            });
        }

        [HttpGet]
        public async Task<ApiResponse> GetProcurementSummary(int EmployeeId, int CurrencyId)
        {
            return await _mediator.Send(new GetProcurementSummaryQuery
            {
                EmployeeId = EmployeeId,
                CurrencyId= CurrencyId
            });
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllDepreciationByFilter([FromBody]GetAllDepreciationByFilterQuery depretiationFilter)
        {
            return await _mediator.Send(depretiationFilter);
        }

        [HttpPost]
        public async Task<ApiResponse> UpdateInvoice([FromBody]UpdateInvoiceCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllPurchaseInvoices([FromQuery]string PurchaseId)
        {
            return await _mediator.Send(new GetAllPurchaseInvoicesQuery()
            {
                PurchaseId= PurchaseId
            });
        }

        [HttpPost]
        public async Task<ApiResponse> UpdatePurchaseImage([FromBody]UpdatePurchaseImageCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> AddItemSpecificationsDetails([FromBody]List<ItemSpecificationDetailModel> model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new AddItemSpecificationsDetailsCommand
            {
                ItemSpecificationDetail = model,
                CreatedById = userId,
                CreatedDate = DateTime.UtcNow
            });   
        }

        [HttpPost]
        public async Task<ApiResponse> EditItemSpecificationsDetails([FromBody]EditItemSpecificationsDetailsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> AddItemSpecificationsMaster([FromBody]AddItemSpecificationsMasterCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditItemSpecificationsMaster([FromBody]EditItemSpecificationsMasterCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<ApiResponse> GetItemSpecificationsMaster([FromQuery]int ItemTypeId, int OfficeId)
        {
            return await _mediator.Send(new GetItemSpecificationsMasterQuery
            {
                ItemTypeId= ItemTypeId,
                OfficeId= OfficeId
            });
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllStatusAtTimeOfIssue()
        {
            return await _mediator.Send(new GetAllStatusAtTimeOfIssueQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllReceiptType()
        {
            return await _mediator.Send(new GetAllReceiptTypeQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetInventoryCode([FromQuery] int Id)
        {
            return await _mediator.Send(new GetInventoryCodeQuery()
            {
                Id= Id
            });
        }

        [HttpGet]
        public async Task<ApiResponse> GetInventoryItemCode([FromQuery] long Id)
        {
            return await _mediator.Send(new GetInventoryItemCodeQuery()
            {
                Id = Id
            });
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllStoreSourceType()
        {
            return await _mediator.Send(new GetAllStoreSourceTypeQuery());
        }

        #endregion
    }
}
