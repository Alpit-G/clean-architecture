﻿using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.HR;
using HumanitarianAssistance.Persistence;
using MediatR;

namespace HumanitarianAssistance.Application.HR.Commands.Create
{
    public class AddEmployeeInfoReferencesCommandHandler : IRequestHandler<AddEmployeeRelativeInformationCommand, ApiResponse>
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;
        private readonly IMapper _mapper;

        public AddEmployeeInfoReferencesCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(AddEmployeeRelativeInformationCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                EmployeeInfoReferences obj = _mapper.Map<EmployeeInfoReferences>(request);
                obj.IsDeleted = false;
                obj.CreatedById = request.CreatedById;
                obj.CreatedDate = DateTime.Now;
                await _dbContext.EmployeeInfoReferences.AddAsync(obj);
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