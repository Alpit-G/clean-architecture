using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.Configuration.Commands.Create
{
    public class AddJournalDetailCommandHandler: IRequestHandler<AddJournalDetailCommand, ApiResponse>
    {

        private readonly HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;
        public AddJournalDetailCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext= dbContext;
            _mapper= mapper;
        }

         public async Task<ApiResponse> Handle(AddJournalDetailCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var existjournal = await _dbContext.JournalDetail.FirstOrDefaultAsync(o => o.JournalName == request.JournalName);
                
                if (existjournal == null)
                {
                    JournalDetail obj = _mapper.Map<JournalDetail>(request);
                    obj.CreatedById = request.CreatedById;
                    obj.CreatedDate = DateTime.UtcNow;
                    obj.IsDeleted = false;
                    await _dbContext.JournalDetail.AddAsync(obj);
                    await _dbContext.SaveChangesAsync();
                    response.StatusCode = StaticResource.successStatusCode;
                    response.Message = "Success";
                }
                else
                {
                    response.StatusCode = StaticResource.MandateNameAlreadyExistCode;
                    response.Message = StaticResource.MandateNameAlreadyExist;
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = StaticResource.SomethingWrong + ex.Message;
            }
            return response;
        }
        
    }
}