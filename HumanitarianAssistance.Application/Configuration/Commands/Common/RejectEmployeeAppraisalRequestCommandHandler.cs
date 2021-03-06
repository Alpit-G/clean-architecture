﻿using AutoMapper;
using HumanitarianAssistance.Application.Configuration.Models;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.HR;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HumanitarianAssistance.Application.Configuration.Commands.Common
{
    public class RejectEmployeeAppraisalRequestCommandHandler : IRequestHandler<RejectEmployeeAppraisalRequestCommand, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;
        public RejectEmployeeAppraisalRequestCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<ApiResponse> Handle(RejectEmployeeAppraisalRequestCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                List<EmployeeAppraisalDetailsModel> lst = new List<EmployeeAppraisalDetailsModel>();
                var emplst = await _dbContext.EmployeeAppraisalDetails.FirstOrDefaultAsync(x => x.EmployeeAppraisalDetailsId == request.EmployeeAppraisalDetailsId && x.AppraisalStatus == false);
                emplst.AppraisalStatus = false;
                emplst.ModifiedById = request.ModifiedById;
                emplst.ModifiedDate = request.ModifiedDate;
                emplst.IsDeleted = true;
                await _dbContext.SaveChangesAsync();

                EmployeeEvaluation evaluationModel = new EmployeeEvaluation();
                evaluationModel.CreatedById = request.CreatedById;
                evaluationModel.CreatedDate = request.CreatedDate;
                evaluationModel.EmployeeId = emplst.EmployeeId;
                evaluationModel.CurrentAppraisalDate = emplst.CurrentAppraisalDate;
                evaluationModel.IsDeleted = true;
                evaluationModel.EvaluationStatus = null;
                evaluationModel.EmployeeAppraisalDetailsId = emplst.EmployeeAppraisalDetailsId;
                await _dbContext.EmployeeEvaluation.AddAsync(evaluationModel);
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
