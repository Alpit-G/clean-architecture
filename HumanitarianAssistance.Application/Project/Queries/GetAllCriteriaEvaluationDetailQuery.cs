﻿using HumanitarianAssistance.Application.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanitarianAssistance.Application.Project.Queries
{
   public class GetAllCriteriaEvaluationDetailQuery : IRequest<ApiResponse>
    {
        public long ProjectId { get; set; }

    }
}
