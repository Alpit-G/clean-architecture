﻿using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Project.Models;
using MediatR;
using System.Collections.Generic;

namespace HumanitarianAssistance.Application.Project.Commands.Create
{
    public class AddPriorityOtherDetailCommand : BaseModel, IRequest<ApiResponse>
    {
        public long? PriorityOtherDetailId { get; set; }
        public string Name { get; set; }
        public long ProjectId { get; set; }
    
    }
}
