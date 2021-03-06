﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities.HR
{
    public class EmployeeHealthQuestion : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int EmployeeHealthQuestionId { get; set; }
        public int EmployeeId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

    }
}
