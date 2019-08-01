using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Marketing.Models;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.Marketing;
using HumanitarianAssistance.Domain.Entities.Project;
using HumanitarianAssistance.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumanitarianAssistance.Application.Project.Commands.Create
{
    public class AddProjectHiringRequestCommandHandler : IRequestHandler<AddProjectHiringRequestCommand, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;
        public AddProjectHiringRequestCommandHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<ApiResponse> Handle(AddProjectHiringRequestCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            //try
            //{
            //    ProjectHiringRequestDetail hiringRequestDeatil = new ProjectHiringRequestDetail()
            //    {
            //        BasicPay = request.BasicPay,
            //        BudgetLineId = request.BudgetLineId,
            //        CreatedById = request.CreatedById,
            //        CreatedDate = DateTime.UtcNow,
            //        CurrencyId = request.CurrencyId,
            //        Description = request.Description,
            //        EmployeeID = request.EmployeeID,
            //        FilledVacancies = request.FilledVacancies,
            //        GradeId = request.GradeId,
            //        IsCompleted = request.IsCompleted,
            //        IsDeleted = false,
            //        OfficeId = request.OfficeId,
            //        Position = request.Position,
            //        ProfessionId = request.ProfessionId,
            //        ProjectId = request.ProjectId,
            //        TotalVacancies = request.TotalVacancies
            //    };
            //    var objdetail = await _dbContext.ProjectHiringRequestDetail.AddAsync(hiringRequestDeatil);
            //    await _dbContext.SaveChangesAsync();

            //    if (objdetail != 0)
            //    {
            //        string description = string.Empty;

            //        JobHiringDetails jobDetail = new JobHiringDetails();
            //        if (!string.IsNullOrEmpty(request.Description))
            //        {

            //            description = request.Description.ToLower().Trim();
            //            jobDetail = await _uow.GetDbContext().JobHiringDetails.Where(x => x.IsDeleted == false &&
            //                                                                              x.JobDescription.ToLower().Trim() == description)
            //                                                                                                    .FirstOrDefaultAsync();
            //        }

            //        if (jobDetail == null)
            //        {
            //            jobDetail = new JobHiringDetails()
            //            {
            //                JobDescription = request.Description,
            //                ProfessionId = request.ProfessionId,
            //                OfficeId = request.OfficeId,
            //                IsActive = true,
            //                GradeId = request.GradeId,
            //                HiringRequestId = hiringRequestDeatil.HiringRequestId,
            //                IsDeleted = false,
            //                CreatedById = userId,
            //                CreatedDate = DateTime.UtcNow,
            //                Unit = request.TotalVacancies.Value

            //            };
            //            await _uow.JobHiringDetailsRepository.AddAsyn(jobDetail);
            //            if (jobDetail.JobId != 0)
            //            {
            //                jobDetail.JobCode = "JC" + String.Format("{0:D4}", jobDetail.JobId);
            //                await _uow.JobHiringDetailsRepository.UpdateAsyn(jobDetail);
            //            }

            //        }

            //        else
            //        {
            //            throw new Exception("Job is already exist");
            //        }


            //    }


            //    response.StatusCode = StaticResource.successStatusCode;
            //    response.Message = "Success";
            //}
            //catch (Exception ex)
            //{
            //    response.StatusCode = StaticResource.failStatusCode;
            //    response.Message = ex.Message;
            //}
            return response;
        }
    }
}
