﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public partial class AssignActivityFeedback : BaseEntityWithoutId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public long FeedbackId { get; set; }
        public long AssignActivityId { get; set; }
        public AssignActivity AssignActivity { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public string Feedback { get; set; }
        public DateTime Date { get; set; }
    }
}
