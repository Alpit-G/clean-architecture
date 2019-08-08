using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.HR;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.Configuration.Commands.Update
{
    public class EditPensionRateCommandHandler : IRequestHandler<EditPensionRateCommand, ApiResponse>
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;
        private readonly IMapper _mapper;
        public EditPensionRateCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper= mapper;
        }

        public async Task<ApiResponse> Handle(EditPensionRateCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();

            try
            {
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
                if (request.IsDefault == false)
                {
                    if (lst == null)
                        request.IsDefault = true;
                    if (lst.IsDefault == true && lst.FinancialYearId == request.FinancialYearId)
                        request.IsDefault = true;
                    else
                        request.IsDefault = false;
                }

                EmployeePensionRate obj = await _dbContext.EmployeePensionRate.FirstOrDefaultAsync(x => x.FinancialYearId == request.FinancialYearId);
                obj.IsDefault = true;
                obj.ModifiedById = request.ModifiedById;
                obj.ModifiedDate = DateTime.Now;
                _mapper.Map(request, obj);
                await _dbContext.SaveChangesAsync();

                response.StatusCode = StaticResource.successStatusCode;
                response.Message = "Success";
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