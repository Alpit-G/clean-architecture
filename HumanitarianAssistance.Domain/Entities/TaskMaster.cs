using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public partial class TaskMaster : BaseEntityWithoutId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        [StringLength(20)]
        public string Priority { get; set; }
        public string Description { get; set; }
        public long? ProjectId { get; set; }
        public ProjectDetails ProjectDetailss { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        public List<ActivityMaster> ActivityMaster { get; set; }

    }
}
