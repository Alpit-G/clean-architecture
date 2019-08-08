using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Configuration.Commands.Create
{
    
    public class AddCurrencyCommand: BaseModel, IRequest<ApiResponse>
    {
        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public float? CurrencyRate { get; set; }
		public bool? Status { get; set; }
    }
}