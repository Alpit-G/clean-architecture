using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Application.Marketing.Models;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities.Marketing;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumanitarianAssistance.Application.Marketing.Commands.Create
{
    public class AddClientDetailsCommandHandler : IRequestHandler<AddClientDetailsCommand, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        public AddClientDetailsCommandHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ApiResponse> Handle(AddClientDetailsCommand request, CancellationToken cancellationToken)
        {
            long LatestClientId = 0;
            var clientcode = string.Empty;
            ApiResponse response = new ApiResponse();
            try
            {
                    var ClientDetail = _dbContext.ClientDetails
                                                           .OrderByDescending(x => x.ClientId)
                                                           .FirstOrDefault();
                    if (ClientDetail == null)
                    {
                        LatestClientId = 1;
                        clientcode = ProjectUtility.GetClientCode(LatestClientId.ToString());
                    }
                    else
                    {
                        LatestClientId = ClientDetail.ClientId + 1;
                        clientcode = ProjectUtility.GetClientCode(LatestClientId.ToString());
                    }
                    ClientDetails objClientDetails = new ClientDetails()
                    {
                        ClientName = request.ClientName,
                        CategoryId = request.CategoryId,
                        ClientBackground = request.ClientBackground,
                        Email = request.Email,
                        FocalPoint = request.FocalPoint,
                        History = request.History,
                        ClientCode = clientcode,
                        Phone = request.Phone,
                        PhysicialAddress = request.PhysicialAddress,
                        Position = request.Position,
                        IsDeleted = request.IsDeleted,
                        CreatedById = request.CreatedById,
                        CreatedDate = DateTime.UtcNow
                    };
                    await _dbContext.ClientDetails.AddAsync(objClientDetails);
                    await _dbContext.SaveChangesAsync();

                    ClientDetailModel obj = new ClientDetailModel();
                    obj.ClientId = objClientDetails.ClientId;
                    obj.ClientName = objClientDetails.ClientName;
                    obj.CategoryId = objClientDetails.CategoryId;
                    obj.ClientBackground = objClientDetails.ClientBackground;
                    obj.Email = objClientDetails.Email;
                    obj.FocalPoint = objClientDetails.FocalPoint;
                    obj.History = objClientDetails.History;
                    obj.ClientCode = objClientDetails.ClientCode;
                    obj.type = "Add";
                    obj.Phone = objClientDetails.Phone;
                    obj.PhysicialAddress = objClientDetails.PhysicialAddress;
                    obj.Position = objClientDetails.Position;
                    obj.Count = await _dbContext.ClientDetails.CountAsync(x => x.IsDeleted == false);
      
                    response.data.clientDetailsById = obj;
                    response.Message = "Client added successfully";
                    response.StatusCode = StaticResource.successStatusCode;
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
