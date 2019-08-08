using HumanitarianAssistance.Application.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanitarianAssistance.Application.Configuration.Commands.Delete
{
   public class DeleteQualifactionDetailsCommand : BaseModel, IRequest<ApiResponse>
    {
        public int QualificationId { get; set; }

    }
}
