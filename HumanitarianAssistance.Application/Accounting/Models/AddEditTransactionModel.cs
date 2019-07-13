using System.Collections.Generic;

namespace HumanitarianAssistance.Application.Accounting.Models
{
    public class AddEditTransactionModel
    {
        public long VoucherNo { get; set; }
        public List<VoucherTransactionsModel> VoucherTransactions { get; set; }
    }
}