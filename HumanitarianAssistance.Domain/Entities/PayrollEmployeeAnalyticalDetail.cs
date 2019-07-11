﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public partial class PayrollEmployeeAnalyticalDetail : BaseEntityWithoutId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int AnalyticalID { get; set; }
        public int? PayrollMonth { get; set; }
        public int? PayrollYear { get; set; }
        public int? EmployeeID { get; set; }
        [StringLength(10)]
        public string Donor { get; set; }
        [StringLength(10)]
        public string AccountCode { get; set; }
        [StringLength(10)]
        public string Area { get; set; }
        [StringLength(10)]
        public string Sector { get; set; }
        [StringLength(10)]
        public string Program { get; set; }
        [StringLength(10)]
        public string Project { get; set; }
        [StringLength(10)]
        public string Job { get; set; }
        [StringLength(10)]
        public string CostBook { get; set; }
        public float? SalaryPercentage { get; set; }
    }
}
