using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using HumanitarianAssistance.Domain.Entities.Store;

namespace HumanitarianAssistance.Domain.Entities
{
    public class ItemSpecificationMaster:BaseEntityWithoutId
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column(Order = 1)]
		public int ItemSpecificationMasterId { get; set; }
		public string ItemSpecificationField { get; set; }
		public int OfficeId { get; set; }
		public OfficeDetail OfficeDetail { get; set; }
		public int ItemTypeId { get; set; }
		[ForeignKey("ItemTypeId")]
		public InventoryItemType InventoryItemType { get; set; }

	}
}
