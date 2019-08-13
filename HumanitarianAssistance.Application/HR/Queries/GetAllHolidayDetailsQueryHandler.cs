using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.HR.Models;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.HR.Queries
{
    public class GetAllHolidayDetailsQueryHandler : IRequestHandler<GetAllHolidayDetailsQuery, ApiResponse>
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllHolidayDetailsQueryHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<ApiResponse> Handle(GetAllHolidayDetailsQuery request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var financialyear = await _dbContext.FinancialYearDetail.FirstOrDefaultAsync(x => x.IsDefault == true);

                var queryResult = EF.CompileAsyncQuery(
                    (HumanitarianAssistanceDbContext ctx) => ctx.HolidayDetails
                    .Where(x => x.IsDeleted == false && x.OfficeId == request.OfficeId && x.FinancialYearId == financialyear.FinancialYearId));
                var holidaylist = await Task.Run(() =>
                    queryResult(_dbContext).ToListAsync().Result
                );

                response.data.HolidayDetailsList = holidaylist;
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
