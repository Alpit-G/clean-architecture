using System.ComponentModel.DataAnnotations;

namespace HumanitarianAssistance.Domain.Entities.Store
{
    public class PurchaseUnitType : BaseEntityWithoutId
    {
        [Key]
        public int UnitTypeId { get; set; }
        public string UnitTypeName { get; set; }
    }
}
