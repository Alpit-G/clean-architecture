using System;

namespace HumanitarianAssistance.Application.Infrastructure
{
    public class BaseModel
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
        public bool? IsDeleted { get; set; }

    }
}