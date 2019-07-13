using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.CommonFunctions;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Persistence;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Commands.Common
{

    public class AddEditTransactionListCommandHandler : IRequestHandler<AddEditTransactionListCommand, ApiResponse>
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;


        public AddEditTransactionListCommandHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ApiResponse> Handle(AddEditTransactionListCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                AccountingFunctions accountingObj = new AccountingFunctions(_dbContext);

                // Common Function to Add/Update Transaction
                bool transactionAddedFlag = accountingObj.AddEditTransactionList(request);

                if (!transactionAddedFlag)
                {
                    throw new Exception(StaticResource.SomethingWentWrong);
                }

                response.StatusCode = StaticResource.successStatusCode;
                response.Message = StaticResource.SuccessText;

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