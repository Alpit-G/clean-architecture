using System;

namespace HumanitarianAssistance.Application.Accounting.Models
{
    public class ExchangeRateVerificationModel
    {
        public long ExRateVerificationId { get; set; }
        public DateTime Date { get; set; }
        public bool IsVerified { get; set; } = false;
    }
}