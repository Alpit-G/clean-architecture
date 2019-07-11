﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public partial class InterviewRoundTypeMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int RoundId { get; set; }
        [StringLength(100)]
        public string RoundTypeName { get; set; }
    }
}
