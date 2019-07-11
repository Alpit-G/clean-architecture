﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public partial class PMUMonitoringDetail : BaseEntityWithoutId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int ActivityID { get; set; }
        public string Answers { get; set; }
        public string VerificationSource { get; set; }
        public string Strengths { get; set; }
        public string Weaknesses { get; set; }
        public string Challenges { get; set; }
        public string Recommendations { get; set; }
        public string Comments { get; set; }
        public int? FrequencyOfMonitoring { get; set; }
    }
}
