using MediatR;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Helpers;
using System.Threading.Tasks;
using System.Threading;
using HumanitarianAssistance.Persistence;
using Microsoft.AspNetCore.Identity;
using HumanitarianAssistance.Domain.Entities;
using AutoMapper.Configuration;

namespace HumanitarianAssistance.Application.Accounting.Commands.Common
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, ApiResponse>
    {

        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly HumanitarianAssistanceDbContext _dbContext;

        public LoginCommandHandler(
                                    HumanitarianAssistanceDbContext dbContext,
                                    SignInManager<AppUser> signInManager,
                                    UserManager<AppUser> userManager,
                                    RoleManager<IdentityRole> roleManager,
                                    IConfiguration config
                                )
        {
            _signInManager = signInManager;
            _dbContext = dbContext;
            _userManager = userManager;
            _configuration = config;
            _roleManager = roleManager;

        }

        public async Task<ApiResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();

            // model validate
            if (request.UserName == null || request.Password == null)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = StaticResource.InvalidUserCredentials;

                return response;
            }

            var result = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, isPersistent: false, lockoutOnFailure: false);


            var user = await _userManager.FindByNameAsync(request.UserName.Trim());
            var result1 = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            return response;

        }


    }
}