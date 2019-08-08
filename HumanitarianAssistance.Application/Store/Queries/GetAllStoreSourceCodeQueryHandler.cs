using AutoMapper;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Store.Models;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.Store;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HumanitarianAssistance.Application.Store.Queries
{
    public class GetAllStoreSourceCodeQueryHandler : IRequestHandler<GetAllStoreSourceCodeQuery, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        private IMapper _mapper;
        public GetAllStoreSourceCodeQueryHandler(HumanitarianAssistanceDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Handle(GetAllStoreSourceCodeQuery request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                List<StoreSourceCodeDetail> StoreSourceCodeDetailList = new List<StoreSourceCodeDetail>();

                //Get Store Source Code Detail based on source code type selected
                if (request.typeId != null)
                {
                    StoreSourceCodeDetailList = await _dbContext.StoreSourceCodeDetail.Where(x => x.IsDeleted == false && x.CodeTypeId == request.typeId).ToListAsync();
                }
                else //Source Code Type is empty so Get all Store Source Code Detail
                {
                    StoreSourceCodeDetailList = await _dbContext.StoreSourceCodeDetail.Where(x => x.IsDeleted == false).ToListAsync();
                }

                List<StoreSourceCodeDetailModel> obj = _mapper.Map<List<StoreSourceCodeDetailModel>>(StoreSourceCodeDetailList);
                response.data.SourceCodeDatalist = obj;
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
