using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HumanitarianAssistance.Application.Configuration.Commands.Delete
{
    public class DeleteQualifactionDetailsCommandHandler : IRequestHandler<DeleteQualifactionDetailsCommand, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;
        public DeleteQualifactionDetailsCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<ApiResponse> Handle(DeleteQualifactionDetailsCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var existrecord = await _dbContext.QualificationDetails.FirstOrDefaultAsync(x => x.QualificationId == request.QualificationId &&
                                                                                                  x.IsDeleted ==false);
                if (existrecord != null)
                {
                    existrecord.IsDeleted = true;
                    existrecord.ModifiedById = request.ModifiedById;
                    existrecord.ModifiedDate = request.ModifiedDate;
                    await _dbContext.SaveChangesAsync();
                    response.StatusCode = StaticResource.successStatusCode;
                    response.Message = "Success";
                }
                else
                {
                    response.StatusCode = StaticResource.failStatusCode;
                    response.Message = "No Record Found";
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = ex.Message;
            }
            return response;

        }
    }
}
