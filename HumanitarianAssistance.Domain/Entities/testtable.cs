﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public partial class testtable
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column(Order = 1)]
		public int id { get; set; }
    }
}
