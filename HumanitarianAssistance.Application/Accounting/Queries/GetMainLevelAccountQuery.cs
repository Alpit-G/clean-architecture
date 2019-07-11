using HumanitarianAssistance.Application.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanitarianAssistance.Application.Accounting.Queries
{
    public class GetMainLevelAccountQuery : IRequest<ApiResponse>
    {
        public long Id { get; set; }
    }
}
