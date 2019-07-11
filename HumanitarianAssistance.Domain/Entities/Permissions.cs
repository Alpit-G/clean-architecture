﻿using HumanitarianAssistance.Common.Helpers;
using System;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public class Permissions
    {
        public Permissions()
        {
            Id = StaticFunctions.GuidGenerator().ToString();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedById { get; set; }
        public AppUser CreatedBy { get; set; }
        public string ModifiedById { get; set; }
        public AppUser ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
