﻿using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.HR.Commands.Update
{
    public class EditEmployeeRelativeInformationCommandHandler : IRequestHandler<EditEmployeeRelativeInformationCommand, ApiResponse>
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;
        private readonly IMapper _mapper;

        public EditEmployeeRelativeInformationCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(EditEmployeeRelativeInformationCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var existRecord = await _dbContext.EmployeeRelativeInfo.FirstOrDefaultAsync(x => x.IsDeleted == false && x.EmployeeRelativeInfoId == request.EmployeeRelativeInfoId);
                if (existRecord != null)
                {
                    existRecord.IsDeleted = false;
                    existRecord.ModifiedById = request.ModifiedById;
                    existRecord.ModifiedDate = DateTime.Now;
                    _mapper.Map(request, existRecord);
                    await _dbContext.SaveChangesAsync();
                    response.StatusCode = StaticResource.successStatusCode;
                    response.Message = "Success";
                }
                else
                {
                    response.StatusCode = StaticResource.failStatusCode;
                    response.Message = "Record not found";
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
