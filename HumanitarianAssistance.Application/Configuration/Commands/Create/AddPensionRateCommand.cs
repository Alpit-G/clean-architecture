using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Configuration.Commands.Create
{
    public class AddPensionRateCommand: BaseModel, IRequest<ApiResponse>
    {
        public int FinancialYearId { get; set; }
		public string FinancialYearName { get; set; }
		public double? PensionRate { get; set; }
		public bool IsDefault { get; set; }
    }
}