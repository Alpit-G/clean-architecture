using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace HumanitarianAssistance.Application.Configuration.Commands.Create
{
    public class AddFinancialYearDetailCommandHandler : IRequestHandler<AddFinancialYearDetailCommand, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;
        public AddFinancialYearDetailCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<ApiResponse> Handle(AddFinancialYearDetailCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                List<FinancialYearDetail> yearlist = await _dbContext.FinancialYearDetail.Where(x => x.IsDeleted == false).ToListAsync();
                if (yearlist != null)
                {
                    if (request.IsDefault == true)
                    {
                        foreach (var i in yearlist)
                        {
                            FinancialYearDetail existrecord1 = await _dbContext.FinancialYearDetail.FirstOrDefaultAsync(x => x.IsDeleted == false && x.FinancialYearId == i.FinancialYearId);
                            existrecord1.IsDefault = false;
                            existrecord1.ModifiedById = request.ModifiedById;
                            existrecord1.ModifiedDate = request.ModifiedDate;
                            await _dbContext.SaveChangesAsync();
                        }
                    }
                    FinancialYearDetail obj = _mapper.Map<FinancialYearDetail>(request);
                    obj.IsDefault = true;
                    await _dbContext.FinancialYearDetail.AddAsync(obj);
                    await _dbContext.SaveChangesAsync();
                }

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