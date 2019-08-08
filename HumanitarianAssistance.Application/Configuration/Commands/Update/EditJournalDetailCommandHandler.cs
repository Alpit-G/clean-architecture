using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.Configuration.Commands.Update
{
    public class EditJournalDetailCommandHandler : IRequestHandler<EditJournalDetailCommand, ApiResponse>
    {

        private readonly HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;
        public EditJournalDetailCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(EditJournalDetailCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var journalInfo = await _dbContext.JournalDetail.FirstOrDefaultAsync(c => c.JournalCode == request.JournalCode);
                journalInfo.JournalName = request.JournalName;
                journalInfo.JournalType = request.JournalType;
                journalInfo.ModifiedById = request.ModifiedById;
                journalInfo.ModifiedDate = request.ModifiedDate;

                _dbContext.JournalDetail.Update(journalInfo);
                await _dbContext.SaveChangesAsync();
                response.StatusCode = StaticResource.successStatusCode;
                response.Message = "Success";
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