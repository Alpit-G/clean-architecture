﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public class OrderSchedulePermission : BaseEntityWithoutId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public long Id { get; set; }
        public int PageId { get; set; }
        public bool OrderSchedule { get; set; }
        [ForeignKey("AspNetUserRoles")]
        public string RoleId { get; set; }
        [ForeignKey("PageId")]
        public ApplicationPages ApplicationPages { get; set; }

    }
}
