﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities.Project
{
    public class CEOccupationDetail : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public long OccupationOtherDetailId { get; set; }
        public string Name { get; set; }
        public long ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public ProjectDetail ProjectDetail { get; set; }
    }
}
