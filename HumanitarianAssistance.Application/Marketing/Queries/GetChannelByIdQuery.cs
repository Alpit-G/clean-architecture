﻿using HumanitarianAssistance.Application.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanitarianAssistance.Application.Marketing.Queries
{
    public class GetChannelByIdQuery:IRequest<ApiResponse>
    {
        public int model { get; set; }
    }
}
