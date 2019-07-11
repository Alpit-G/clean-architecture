﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public partial class EmployeeSalaryBudgetDetail : BaseEntity
    {
        public int? EmployeeID { get; set; }
	    public int? Year { get; set; }
        [StringLength(5)]
        public string CurrencyCode { get; set; }
        public float? SalaryBudget { get; set; }
        public float? BudgetDisbursed { get; set; }
    }
}
