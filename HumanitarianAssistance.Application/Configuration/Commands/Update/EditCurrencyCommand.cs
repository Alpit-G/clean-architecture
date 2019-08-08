using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Configuration.Commands.Update
{
    public class EditCurrencyCommand: BaseModel, IRequest<ApiResponse>
    {
        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public float? CurrencyRate { get; set; }
		public bool? Status { get; set; }
    }
}