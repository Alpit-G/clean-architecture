using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanitarianAssistance.Domain.Entities
{
    public class EmployeeAppraisalQuestions: BaseEntityWithoutId
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column(Order = 1)]
		public int EmployeeAppraisalQuestionsId { get; set; }
		public int AppraisalGeneralQuestionsId { get; set; }
		public AppraisalGeneralQuestions AppraisalGeneralQuestions { get; set; }
		public int? Score { get; set; }
		public string Remarks { get; set; }
		public DateTime CurrentAppraisalDate { get; set; }
		public int EmployeeId { get; set; }
	}
}
