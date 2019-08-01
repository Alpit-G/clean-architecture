using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumanitarianAssistance.Application.Marketing.Queries
{
    public class GetPolicyListQueryHandler : IRequestHandler<GetPolicyListQuery, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        public GetPolicyListQueryHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ApiResponse> Handle(GetPolicyListQuery request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                int count = await _uow.GetDbContext().PolicyDetails.CountAsync(x => x.IsDeleted == false);
                var policyDetail = await (from j in _uow.GetDbContext().PolicyDetails
                                          join jp in _uow.GetDbContext().LanguageDetail on j.LanguageId equals jp.LanguageId
                                          join me in _uow.GetDbContext().Mediums on j.MediumId equals me.MediumId
                                          join mc in _uow.GetDbContext().MediaCategories on j.MediaCategoryId equals mc.MediaCategoryId
                                          where !j.IsDeleted.Value && !jp.IsDeleted.Value && !me.IsDeleted.Value
                                          && !mc.IsDeleted.Value
                                          select (new PolicyModel
                                          {
                                              PolicyId = j.PolicyId,
                                              PolicyName = j.PolicyName,
                                              PolicyCode = j.PolicyCode,
                                              Description = j.Description,
                                              LanguageId = jp.LanguageId,
                                              LanguageName = jp.LanguageName,
                                              MediumId = me.MediumId,
                                              MediumName = me.MediumName,
                                              MediaCategoryId = mc.MediaCategoryId,
                                              MediaCategoryName = mc.CategoryName
                                          })).Take(10).Skip(0).OrderByDescending(x => x.CreatedDate).ToListAsync();

                response.data.policyList = policyDetail;
                response.data.TotalCount = count;
                response.StatusCode = 200;
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
