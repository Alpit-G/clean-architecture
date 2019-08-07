using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Marketing.Commands.Create;
using HumanitarianAssistance.Common.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
namespace HumanitarianAssistance.WebApi.Controllers.Marketing
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/PdfController/[Action]")]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Marketing))]
    public class PdfController : BaseController
    {
        [HttpPost]
        public async Task<ApiResponse> CreatePDF([FromBody]int jobId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return await _mediator.Send(new CreatePDFCommand
            {
                JobId = jobId, 
                ModifiedById = userId,
                ModifiedDate = DateTime.UtcNow
            });
        }

        
    }
}
