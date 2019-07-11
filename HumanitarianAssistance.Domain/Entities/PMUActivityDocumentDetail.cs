﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public partial class PMUActivityDocumentDetail : BaseEntityWithoutId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int DocumentID { get; set; }
        [StringLength(100)]
        public string DocumentName { get; set; }
        [StringLength(200)]
        public string DocumentFilePath { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int? ActivityID { get; set; }
    }
}
