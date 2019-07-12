using System.Collections.Generic;

namespace HumanitarianAssistance.Application.Accounting.Models
{
    public class AddExchangeRateModel
    {
        public List<GenerateExchangeRateModel> ExchangeRatesViewModel { get; set; }
        public bool SaveForAllOffices { get; set; }
        public int? OfficeId { get; set; }
    }
}