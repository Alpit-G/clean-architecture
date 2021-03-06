﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.Project.Queries
{
    public class GetProjectJobDetailByProjectIdQueryHandler : IRequestHandler<GetProjectJobDetailByProjectIdQuery, ApiResponse>
    {

        private HumanitarianAssistanceDbContext _dbContext;

        public GetProjectJobDetailByProjectIdQueryHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ApiResponse> Handle(GetProjectJobDetailByProjectIdQuery request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {

                var list = await _dbContext.ProjectJobDetail.Where(x => x.IsDeleted == false &&
                                                                                 x.ProjectId == request.ProjectId)
                                                                            .OrderByDescending(x => x.ProjectJobName)
                                                                            .ToListAsync();
                response.data.ProjectJobDetail = list;
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
