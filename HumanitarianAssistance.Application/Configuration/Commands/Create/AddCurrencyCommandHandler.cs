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
    public class AddCurrencyCommandHandler: IRequestHandler<AddCurrencyCommand, ApiResponse>
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;
        private readonly IMapper _mapper;
        public AddCurrencyCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper= mapper;
        }

        public async Task<ApiResponse> Handle(AddCurrencyCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var existcurrency = await _dbContext.CurrencyDetails.FirstOrDefaultAsync(c => c.CurrencyCode == request.CurrencyCode);
               
                if (existcurrency == null)
                {
                    if (request.Status == true)
                    {
                        var currencylist = await _dbContext.CurrencyDetails.ToListAsync();

                        foreach (var i in currencylist)
                        {
                             var existrecord1 = await _dbContext.CurrencyDetails.FirstOrDefaultAsync(x => x.CurrencyId == i.CurrencyId);
                             existrecord1.Status = false;
                            _dbContext.CurrencyDetails.Update(existrecord1);
                            await _dbContext.SaveChangesAsync();
                        }
                    }

                    CurrencyDetails obj = _mapper.Map<CurrencyDetails>(request);
                    obj.CreatedById = request.CreatedById;
                    obj.CreatedDate = DateTime.UtcNow;
                    obj.IsDeleted = false;
                    await _dbContext.CurrencyDetails.AddAsync(obj);
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