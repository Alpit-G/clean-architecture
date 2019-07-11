using HumanitarianAssistance.Common.Helpers;
using System;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
   public class BaseEntity
    {
        public BaseEntity()
        {
            Id = StaticFunctions.GuidGenerator();
        }
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedById { get; set; }
        //public AppUser CreatedBy { get; set; }
        public string ModifiedById { get; set; }
        //public AppUser ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

    }

}
