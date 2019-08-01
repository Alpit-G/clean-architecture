using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HumanitarianAssistance.Domain.Entities.Project;

namespace HumanitarianAssistance.Domain.Entities
{
    public class BudgetReceivable : BaseEntityWithoutId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public long BudgetReceivalbeId { get; set; }
        //public long BudgetId { get; set; }
        public long? ProjectId { get; set; }
        public ProjectDetails ProjectDetails { get; set; }
        public long BudgetLineId { get; set; }
        public ProjectBudgetLine ProjectBudgetLine { get; set; }
        public double Amount { get; set; }
        public DateTime ExpectedDate { get; set; }

    }
}
