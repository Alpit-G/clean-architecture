using System.ComponentModel.DataAnnotations;
using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Configuration.Commands.Create
{
    public class AddCurrencyCommand : BaseModel, IRequest<ApiResponse>
    {
        public int CurrencyId { get; set; }
        [StringLength(5)]
        public string CurrencyCode { get; set; }
        [StringLength(50)]
        public string CurrencyName { get; set; }
    }
}