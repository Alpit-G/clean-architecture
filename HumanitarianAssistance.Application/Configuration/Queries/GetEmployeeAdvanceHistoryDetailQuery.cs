﻿using HumanitarianAssistance.Application.Infrastructure;
using MediatR;

namespace HumanitarianAssistance.Application.Configuration.Queries
{
    public class GetEmployeeAdvanceHistoryDetailQuery : IRequest<ApiResponse>
    {
        public long AdvanceID { get; set; } 
    }
}
