﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HumanitarianAssistance.Application.Project.Models
{
    public class SPBudgetLineBeakdown
    {
        public DateTime VoucherDate { get; set; }
        public double Expenditure { get; set; }
        public int Currencyid { get; set; }
    }
}