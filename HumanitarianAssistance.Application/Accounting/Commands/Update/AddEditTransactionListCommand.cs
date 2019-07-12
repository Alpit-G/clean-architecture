using System.Collections.Generic;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Commands.Update
{
    public class AddEditTransactionListCommand : BaseModel, IRequest<ApiResponse>
    {
        public AddEditTransactionListCommand()
        {
            VoucherTransactions = new List<VoucherTransactionsModel>();
        }
        public long VoucherNo { get; set; }
        public List<VoucherTransactionsModel> VoucherTransactions { get; set; }
    }
}