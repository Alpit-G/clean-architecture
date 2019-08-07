using System;
using System.Threading;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.Project;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace HumanitarianAssistance.Application.Project.Commands.Common
{
    public class AddEditProjectOtherDetailCommandHandler: IRequestHandler<AddEditProjectOtherDetailCommand, ApiResponse>
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;
        public AddEditProjectOtherDetailCommandHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext= dbContext;
        }

        public async Task<ApiResponse> Handle(AddEditProjectOtherDetailCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            long LatestProjectOtherDetailId = 0;

            using (IDbContextTransaction tran = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var Projectdetail = await _dbContext.ProjectOtherDetail.FirstOrDefaultAsync(x => x.IsDeleted == false && x.ProjectId == request.ProjectId);
                    
                    if (Projectdetail == null)
                    {
                        ProjectOtherDetail obj = new ProjectOtherDetail
                        {
                            opportunityNo = request.opportunityNo,
                            opportunity = request.opportunity,
                            opportunitydescription = request.opportunitydescription,
                            ProvinceId = request.ProvinceId,
                            ProjectId = request.ProjectId,
                            DistrictID = request.DistrictID,
                            OfficeId = request.OfficeId,
                            StartDate = request.StartDate,
                            EndDate = request.EndDate,
                            CurrencyId = request.CurrencyId,
                            budget = request.budget,
                            beneficiaryMale = request.beneficiaryMale,
                            beneficiaryFemale = request.beneficiaryFemale,
                            projectGoal = request.projectGoal,
                            projectObjective = request.projectObjective,
                            mainActivities = request.mainActivities,
                            DonorId = request.DonorId,
                            SubmissionDate = request.SubmissionDate,
                            REOIReceiveDate = request.REOIReceiveDate,
                            StrengthConsiderationId = request.StrengthConsiderationId,
                            GenderConsiderationId = request.GenderConsiderationId,
                            GenderRemarks = request.GenderRemarks,
                            SecurityId = request.SecurityId,
                            SecurityConsiderationId = request.SecurityConsiderationId,
                            SecurityRemarks = request.SecurityRemarks,
                            IsDeleted = false,
                            CreatedById = request.CreatedById,
                            CreatedDate = DateTime.UtcNow,
                            InDirectBeneficiaryFemale = request.InDirectBeneficiaryFemale,
                            InDirectBeneficiaryMale = request.InDirectBeneficiaryMale,
                            OpportunityType = request.OpportunityType
                        };

                        await _dbContext.ProjectOtherDetail.AddAsync(obj);
                        await _dbContext.SaveChangesAsync();

                        LatestProjectOtherDetailId = obj.ProjectOtherDetailId;
                    }
                    else
                    {
                        var existProjectRecord = await _dbContext.ProjectOtherDetail.FirstOrDefaultAsync(x => x.IsDeleted == false && x.ProjectOtherDetailId == request.ProjectOtherDetailId && x.ProjectId == request.ProjectId);
                        
                        if (existProjectRecord != null)
                        {
                            existProjectRecord.opportunityNo = request.opportunityNo;
                            existProjectRecord.ProjectId = request.ProjectId;
                            existProjectRecord.opportunity = request.opportunity;
                            existProjectRecord.opportunitydescription = request.opportunitydescription;
                            existProjectRecord.ProvinceId = request.ProvinceId;
                            existProjectRecord.DistrictID = request.DistrictID;
                            existProjectRecord.OfficeId = request.OfficeId;
                            existProjectRecord.StartDate = request.StartDate;
                            existProjectRecord.EndDate = request.EndDate;
                            existProjectRecord.CurrencyId = request.CurrencyId;
                            existProjectRecord.budget = request.budget;
                            existProjectRecord.beneficiaryMale = request.beneficiaryMale;
                            existProjectRecord.beneficiaryFemale = request.beneficiaryFemale;
                            existProjectRecord.projectGoal = request.projectGoal;
                            existProjectRecord.projectObjective = request.projectObjective;
                            existProjectRecord.mainActivities = request.mainActivities;
                            existProjectRecord.DonorId = request.DonorId;
                            existProjectRecord.SubmissionDate = request.SubmissionDate;
                            existProjectRecord.REOIReceiveDate = request.REOIReceiveDate;
                            existProjectRecord.StrengthConsiderationId = request.StrengthConsiderationId;
                            existProjectRecord.GenderConsiderationId = request.GenderConsiderationId;
                            existProjectRecord.GenderRemarks = request.GenderRemarks;
                            existProjectRecord.SecurityId = request.SecurityId;
                            existProjectRecord.SecurityConsiderationId = request.SecurityConsiderationId;
                            existProjectRecord.SecurityRemarks = request.SecurityRemarks;
                            existProjectRecord.IsDeleted = false;
                            existProjectRecord.ModifiedById = request.ModifiedById;
                            existProjectRecord.ModifiedDate = DateTime.UtcNow;
                            existProjectRecord.InDirectBeneficiaryFemale = request.InDirectBeneficiaryFemale;
                            existProjectRecord.InDirectBeneficiaryMale = request.InDirectBeneficiaryMale;
                            existProjectRecord.OpportunityType = request.OpportunityType;

                            _dbContext.ProjectOtherDetail.Update(existProjectRecord);
                            await _dbContext.SaveChangesAsync();
                            LatestProjectOtherDetailId = request.ProjectOtherDetailId;
                        }
                    }
                    response.StatusCode = StaticResource.successStatusCode;
                    response.CommonId.Id = Convert.ToInt32(LatestProjectOtherDetailId);

                    response.Message = "Success";
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    response.StatusCode = StaticResource.failStatusCode;
                    response.Message = StaticResource.SomethingWrong + ex.Message;
                }
            }

            return response;
        }
    }
}