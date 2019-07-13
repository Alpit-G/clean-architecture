using System.Collections.Generic;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Commands.Create
{
    public class AddExchangeRateCommand : BaseModel, IRequest<ApiResponse>
    {
        public List<GenerateExchangeRateModel> GenerateExchangeRateModel { get; set; }
    }
}