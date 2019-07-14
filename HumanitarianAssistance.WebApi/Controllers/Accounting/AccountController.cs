using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Accounting.Commands.Common;
using HumanitarianAssistance.Application.Accounting.Commands.Create;
using HumanitarianAssistance.Application.Accounting.Commands.Update;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Accounting.Queries;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Enums;
using HumanitarianAssistance.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HumanitarianAssistance.WebApi.Controllers.Accounting
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/Account/[Action]")]
    [Authorize]
    [ApiExplorerSettings(GroupName = nameof(SwaggerGrouping.Accounting))]
    public class AccountController : Controller
    {

        private readonly IMediator _mediator;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(IMediator mediator, UserManager<AppUser> userManager)
        {
            _mediator = mediator;
            _userManager = userManager;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ApiResponse> Login([FromBody]LoginCommand model)
        {
            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> AddUsers([FromBody]AddUserCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> EditUsers([FromBody]EditUsersCommand model)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            model.ModifiedById = userId;
            model.ModifiedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> ChangePassword([FromBody]ChangeUserPasswordCommand model)
        {

            model.ModifiedById = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> ResetPassword([FromBody]ResetUserPasswordCommand model)
        {

            model.ModifiedById = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            model.ModifiedDate = DateTime.UtcNow;

            return await _mediator.Send(model);
        }

        [HttpPost]
        public async Task<ApiResponse> AssignRoleToUser([FromBody]AssignRoleToUserCommand model)
        {
            return await _mediator.Send(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetRoles()
        {
            return await _mediator.Send(new GetAllRolesQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllUserDetails()
        {
            return await _mediator.Send(new GetAllUserDetailsQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllUserList()
        {
            return await _mediator.Send(new GetAllUserListQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetUserDetailsByUserId(string UserId)
        {
            return await _mediator.Send(new GetUserDetailsByUserIdQuery { UserId = UserId });
        }

        [HttpGet]
        public async Task<ApiResponse> GetPermissionByRoleId(string roleid)
        {
            return await _mediator.Send(new GetPermissionByRoleIdQuery { RoleId = roleid });
        }

        [HttpGet]
        public async Task<ApiResponse> GetPermissions()
        {
            return await _mediator.Send(new GetAllPermissionsQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetUserRole(string userid)
        {
            return await _mediator.Send(new GetUserRolesByUserIdQuery { UserId = userid });
        }

        [HttpGet]
        public async Task<ApiResponse> CheckCurrentPassword(string pwd)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                if (pwd != null)
                {
                    var user = await _userManager.FindByNameAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);

                    if (await _userManager.CheckPasswordAsync(user, pwd))
                    {
                        response.StatusCode = 200;
                    }
                    else
                    {
                        response.StatusCode = 401;
                    }
                }
                else
                {
                    response.StatusCode = 401;
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = 400;
                response.Message = ex.Message;
            }
            return response;
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllVouchersByOfficeId(int officeid)
        {
            return await _mediator.Send(new GetAllVouchersByOfficeIdQuery { OfficeId = officeid });
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllVoucherType()
        {
            return await _mediator.Send(new GetAllVoucherTypeQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllAccountCode()
        {
            return await _mediator.Send(new GetAllAccountsQuery());
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllUserNotifications(string userid)
        {
            return await _mediator.Send(new GetAllUserNotificationsQuery { UserId = userid });
        }

        [HttpGet]
        public async Task<ApiResponse> GetAllInputLevelAccountCode()
        {
            return await _mediator.Send(new GetAllInputLevelAccountsQuery());
        }

        [HttpPost]
        public async Task<ApiResponse> GenerateSalaryVoucher([FromBody]GenerateSalaryVoucherCommand model)
        {
            return await _mediator.Send(model);
        }

    }
}