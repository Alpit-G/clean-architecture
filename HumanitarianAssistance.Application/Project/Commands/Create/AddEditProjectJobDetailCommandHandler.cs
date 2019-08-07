using AutoMapper;
using HumanitarianAssistance.Application.CommonFunctions.Project;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.Project;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HumanitarianAssistance.Application.Project.Commands.Create
{
    public class AddEditProjectJobDetailCommandHandler : IRequestHandler<AddEditProjectJobDetailCommand, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;
        public AddEditProjectJobDetailCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<ApiResponse> Handle(AddEditProjectJobDetailCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                if (request.ProjectId != 0)
                {
                    ProjectJobDetail obj = _mapper.Map<AddEditProjectJobDetailCommand, ProjectJobDetail>(request);

                    if (request.ProjectJobId == 0)
                    {
                        obj.CreatedDate = request.CreatedDate;
                        obj.IsDeleted = false;
                        obj.CreatedById = request.CreatedById;

                        await _dbContext.ProjectJobDetail.AddAsync(obj);

                        if (obj.ProjectJobId != 0)
                        {
                            // update project job code
                            ProjectFunctions projectFunctions = new ProjectFunctions(_dbContext);
                            obj.ProjectJobCode = await projectFunctions.GetProjectJobCode(obj);

                            await _dbContext.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        ProjectJobDetail projectJobDetail = await _dbContext.ProjectJobDetail.FirstOrDefaultAsync(x => x.IsDeleted == false &&
                                                                                                                                x.ProjectJobId == request.ProjectJobId);
                        if (projectJobDetail != null)
                        {
                            projectJobDetail.ProjectJobCode = obj.ProjectJobCode;
                            projectJobDetail.ProjectJobName = obj.ProjectJobName;
                            projectJobDetail.ProjectJobId = obj.ProjectJobId;
                            projectJobDetail.ProjectId = obj.ProjectId;
                            obj.ModifiedById = request.ModifiedById;
                            obj.ModifiedDate = request.ModifiedDate;
                            obj.IsDeleted = false;

                            await _dbContext.SaveChangesAsync();
                        }
                    }

                    response.StatusCode = StaticResource.successStatusCode;
                    response.Message = "Success";
                }
                else
                {
                    response.StatusCode = StaticResource.projectNotFound;
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
