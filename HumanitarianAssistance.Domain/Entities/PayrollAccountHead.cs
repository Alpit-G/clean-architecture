﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public partial class PayrollAccountHead : BaseEntityWithoutId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int PayrollHeadId { get; set; }
        public int PayrollHeadTypeId { get; set; }
        public string PayrollHeadName { get; set; }
        public string Description { get; set; }
        public long? AccountNo { get; set; }
        public int? TransactionTypeId { get; set; }
    }
}
