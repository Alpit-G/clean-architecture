using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.CommonServices;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.Accounting;
using HumanitarianAssistance.Persistence;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Commands.Common
{
    public class ReverseEmployeeSalaryVoucherCommandHandler : IRequestHandler<ReverseEmployeeSalaryVoucherCommand, ApiResponse>
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;

        public ReverseEmployeeSalaryVoucherCommandHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ApiResponse> Handle(ReverseEmployeeSalaryVoucherCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();

            VoucherDetail voucherDetail = new VoucherDetail();

            try
            {
                AccountingServices accountingObj = new AccountingServices(_dbContext);

                if (await accountingObj.ReverseEmployeeSalaryVoucher(request))
                {
                    response.StatusCode = StaticResource.successStatusCode;
                    response.Message = "Success";
                }
                else
                {
                    response.StatusCode = StaticResource.failStatusCode;
                    response.Message = StaticResource.SomethingWentWrong; ;

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