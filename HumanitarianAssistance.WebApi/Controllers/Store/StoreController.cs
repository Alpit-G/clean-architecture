using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HumanitarianAssistance.Common.Enums;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Store.Queries;
using System.Security.Claims;
using System;
using HumanitarianAssistance.Application.Store.Commands.Create;
using HumanitarianAssistance.Application.Store.Commands.Update;
using HumanitarianAssistance.Application.Store.Commands.Delete;
using HumanitarianAssistance.Application.Store.Commands.Common;

namespace HumanitarianAssistance.WebApi.Controllers.Store
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/Store/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Store))]
    [Authorize]
    public class StoreController : BaseController
    {

        #region "Store Inventories"
        [HttpPost]
        public async Task<ApiResponse> GetAllInventories(int? AssetType)
        {
            return await _mediator.Send(new GetAllInventoriesQuery { AssetType = AssetType });
        }

        [HttpPost]
        public async Task<ApiResponse> AddInventory([FromBody]AddInventoryCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditInventory([FromBody]EditInventoryCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> DeleteInventory([FromBody]DeleteInventoryCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        #endregion

        #region "Store Items"

        [HttpPost]
        public async Task<ApiResponse> AddInventoryItems([FromBody]AddInventoryItemsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditInventoryItems([FromBody]EditInventoryItemsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> DeleteInventoryItems([FromBody]DeleteInventoryItemsCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllInventoryItems(long Id)
        {
            return await _mediator.Send(new GetAllInventoryItemsQuery { ItemGroupId = Id });
        }

        #endregion

        #region "Store Item Types"

        [HttpPost]
        public async Task<ApiResponse> AddInventoryItemsType([FromBody]AddInventoryItemsTypeCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> EditInventoryItemsType([FromBody]EditInventoryItemsTypeCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> DeleteInventoryItemsType([FromBody]DeleteInventoryItemsTypeCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpGet]
        public async Task<ApiResponse> GetAllInventoryItemsType()
        {
            return await _mediator.Send(new GetAllInventoryItemsTypeQuery());
        }
        #endregion

        #region "Store Purchase"

        //Not used in front end
        [HttpPost]
        public async Task<ApiResponse> GetSerialNumber(string serialNumber)
        {
            return await _mediator.Send(new GetSerialNumberQuery { serialNumber = serialNumber });
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllPurchasesByItem(string itemId)
        {
            return await _mediator.Send(new GetAllPurchasesByItemQuery { itemId = itemId });
        }

        [HttpPost]
        public async Task<ApiResponse> AddPurchase([FromBody]AddPurchaseCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditPurchase([FromBody]EditPurchaseCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> DeletePurchase([FromBody]DeletePurchaseCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        #endregion

        #region "Others"
        [HttpPost]
        public async Task<ApiResponse> GetAllStoreSourceCode(int? typeId)
        {
            return await _mediator.Send(new GetAllStoreSourceCodeQuery { typeId = typeId });
        }
        [HttpPost]
        public async Task<ApiResponse> AddStoreSourceCode([FromBody]AddStoreSourceCodeCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost] 
        public async Task<ApiResponse> GetStoreTypeCode([FromQuery]int CodeTypeId)
        {
            return await _mediator.Send(new GetStoreTypeCodeQuery { CodeTypeId = CodeTypeId });
        }

        [HttpPost]  
        public async Task<ApiResponse> EditStoreSourceCode([FromBody]EditStoreSourceCodeCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost] 
        public async Task<ApiResponse> DeleteStoreSourceCode([FromQuery]int Id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new DeleteStoreSourceCodeCommand
            {
                storeSourceCodeId = Id,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }
        [HttpGet] 
        public async Task<ApiResponse> GetAllPaymentTypes()
        {
            return await _mediator.Send(new GetAllPaymentTypesQuery()); 
        }
        [HttpPost]
        public async Task<ApiResponse> AddPaymentTypes([FromBody]AddPaymentTypesCommand command)
        {  
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> EditPaymentTypes([FromBody]EditPaymentTypesCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow; 
            return await _mediator.Send(command);
        }
        [HttpPost] 
        public async Task<ApiResponse> DeletePaymentTypes([FromQuery] int PaymentId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new DeletePaymentTypesCommand
            {
                PaymentId = PaymentId,
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        [HttpPost]
        public async Task<ApiResponse> UnverifyPurchase([FromBody]UnverifyPurchaseCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> AddStoreItemGroup([FromBody]AddStoreItemGroupCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.CreatedById = userId;
            command.CreatedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }
        [HttpPost]
        public async Task<ApiResponse> GetStoreGroupItemCode([FromQuery]string Id)
        {
            return await _mediator.Send(new GetStoreGroupItemCodeQuery { inventoryId = Id });
        }

        [HttpPost]
        public async Task<ApiResponse> EditStoreItemGroup([FromBody]EditStoreItemGroupCommand command)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            command.ModifiedById = userId;
            command.ModifiedDate = DateTime.UtcNow;
            return await _mediator.Send(command);
        }

        [HttpPost]
        public async Task<ApiResponse> GetAllStoreItemGroups([FromQuery]string Id)
        {
            return await _mediator.Send(new GetAllStoreItemGroupsQuery { inventoryId = Id });
        }
        #endregion
    }

}


