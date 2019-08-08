using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.HR;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.Configuration.Commands.Create
{
    public class AddPensionRateCommandHandler: IRequestHandler<AddPensionRateCommand, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;
        public AddPensionRateCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

         public async Task<ApiResponse> Handle(AddPensionRateCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                if (request != null)
                {
                    var financialYearCheck = await _dbContext.EmployeePensionRate.Where(x => x.FinancialYearId == request.FinancialYearId).ToListAsync();

                    if (!financialYearCheck.Any())
                    {
                        EmployeePensionRate obj = _mapper.Map<EmployeePensionRate>(request);

                        var lst = await _dbContext.EmployeePensionRate.FirstOrDefaultAsync(x => x.IsDefault == true);
                        
                        if (request.IsDefault == true)
                        {
                            if (lst != null)
                            {
                                lst.IsDefault = false;
                                _dbContext.EmployeePensionRate.Update(lst);
                                await _dbContext.SaveChangesAsync();
                            }
                        }
                        obj.IsDefault = (request.IsDefault == false && lst == null) ? true : request.IsDefault;
                        obj.CreatedById = request.CreatedById;
                        obj.CreatedDate = DateTime.Now;
                        obj.IsDeleted = false;

                        await _dbContext.EmployeePensionRate.AddAsync(obj);
                        await _dbContext.SaveChangesAsync();
                        response.StatusCode = StaticResource.successStatusCode;
                        response.Message = "Success";
                    }
                    else
                    {
                        response.StatusCode = 700;
                        response.Message = "Financial Year Already exists!";
                    }
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