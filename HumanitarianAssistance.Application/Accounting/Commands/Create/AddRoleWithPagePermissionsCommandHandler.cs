using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.CommonFunctions;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Domain.Entities;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.Accounting.Commands.Create
{

    public class AddRoleWithPagePermissionsCommandHandler : IRequestHandler<AddRoleWithPagePermissionsCommand, ApiResponse>
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;


        public AddRoleWithPagePermissionsCommandHandler(HumanitarianAssistanceDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
        }

        public async Task<ApiResponse> Handle(AddRoleWithPagePermissionsCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                if (request != null)
                {
                    AccountingFunctions accountingObj = new AccountingFunctions(_dbContext, _roleManager);

                    // Add Role
                    if (await accountingObj.AddRole(request.RoleName))
                    {
                        var role = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Name == request.RoleName);

                        if (request != null)
                        {
                            List<RolePermissions> rolePermissionsList = new List<RolePermissions>();

                            foreach (ApplicationPagesModel item in request.Permissions)
                            {
                                if (item.Edit == true || item.View == true)
                                {
                                    RolePermissions rolePermissions = new RolePermissions();
                                    rolePermissions.CanEdit = item.Edit;
                                    rolePermissions.CanView = item.View;
                                    rolePermissions.CreatedDate = DateTime.UtcNow;
                                    rolePermissions.IsDeleted = false;
                                    rolePermissions.PageId = item.PageId;
                                    rolePermissions.RoleId = role.Id;
                                    rolePermissions.ModuleId = item.ModuleId;

                                    await _dbContext.RolePermissions.AddAsync(rolePermissions);
                                    await _dbContext.SaveChangesAsync();
                                    _dbContext.Entry<RolePermissions>(rolePermissions).State = EntityState.Detached;
                                }
                                if (item.Approve == true || item.Reject == true)
                                {
                                    ApproveRejectPermission rolePermission = new ApproveRejectPermission();
                                    rolePermission.Approve = item.Approve;
                                    rolePermission.Reject = item.Reject;
                                    rolePermission.CreatedDate = DateTime.UtcNow;
                                    rolePermission.IsDeleted = false;
                                    rolePermission.PageId = item.PageId;
                                    rolePermission.RoleId = role.Id;

                                    await _dbContext.ApproveRejectPermission.AddAsync(rolePermission);
                                    await _dbContext.SaveChangesAsync();
                                    _dbContext.Entry<ApproveRejectPermission>(rolePermission).State = EntityState.Detached;
                                }
                                if (item.Agree == true || item.Disagree == true)
                                {
                                    AgreeDisagreePermission rolePermission = new AgreeDisagreePermission();
                                    rolePermission.Agree = item.Agree;
                                    rolePermission.Disagree = item.Disagree;
                                    rolePermission.CreatedDate = DateTime.UtcNow;
                                    rolePermission.IsDeleted = false;
                                    rolePermission.PageId = item.PageId;
                                    rolePermission.RoleId = role.Id;

                                    await _dbContext.AgreeDisagreePermission.AddAsync(rolePermission);
                                    await _dbContext.SaveChangesAsync();
                                    _dbContext.Entry<AgreeDisagreePermission>(rolePermission).State = EntityState.Detached;
                                }
                                if (item.OrderSchedule == true)
                                {
                                    OrderSchedulePermission rolePermission = new OrderSchedulePermission();
                                    rolePermission.OrderSchedule = item.OrderSchedule;
                                    rolePermission.CreatedDate = DateTime.UtcNow;
                                    rolePermission.IsDeleted = false;
                                    rolePermission.PageId = item.PageId;
                                    rolePermission.RoleId = role.Id;

                                    await _dbContext.OrderSchedulePermission.AddAsync(rolePermission);
                                    await _dbContext.SaveChangesAsync();
                                    _dbContext.Entry<OrderSchedulePermission>(rolePermission).State = EntityState.Detached;
                                }
                            }

                            response.StatusCode = StaticResource.successStatusCode;
                            response.Message = StaticResource.SuccessText;
                        }
                        else
                        {
                            response.StatusCode = StaticResource.failStatusCode;
                            response.Message = StaticResource.NoDataFound;
                        }
                    }
                }
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