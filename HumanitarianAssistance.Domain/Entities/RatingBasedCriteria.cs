﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public class RatingBasedCriteria : BaseEntityWithoutId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int RatingBasedCriteriaId { get; set; }

        public int InterviewDetailsId { get; set; }
        public string CriteriaQuestion { get; set; }
        public int? Rating { get; set; }
        [ForeignKey("InterviewDetailsId")]
        public InterviewDetails InterviewDetails { get; set; }
    }
}
