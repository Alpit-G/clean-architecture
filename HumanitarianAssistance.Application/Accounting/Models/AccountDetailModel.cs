namespace HumanitarianAssistance.Application.Accounting.Models
{
    public class AccountDetailModel
    {
        public long AccountCode { get; set; }
        public string AccountName
        {
            get
            {
                return AccountName;
            }
            set
            {
                AccountName = ChartOfAccountNewCode + "-" + AccountName;
            }
        }
        public string ChartOfAccountNewCode { get; set; }
        public int AccountLevelId { get; set; }
    }
}