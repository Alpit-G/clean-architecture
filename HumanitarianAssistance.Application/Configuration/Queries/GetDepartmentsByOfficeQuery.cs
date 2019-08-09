﻿using HumanitarianAssistance.Application.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanitarianAssistance.Application.Configuration.Queries
{
   public class GetDepartmentsByOfficeQuery : IRequest<ApiResponse>
    {
        public int OfficeId { get; set; }
    }
}