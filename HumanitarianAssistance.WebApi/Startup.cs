using MediatR;
using HumanitarianAssistance.Application.Accounting.Queries;
using HumanitarianAssistance.Domain.Entities;
using HumanitarianAssistance.Infrastructure.Extensions;
using HumanitarianAssistance.Persistence;
using HumanitarianAssistance.WebApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HumanitarianAssistance.WebApi
{
    public class Startup
    {

        string DefaultCorsPolicyName = string.Empty;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // db connection
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<HumanitarianAssistanceDbContext>(options => options.UseNpgsql(connectionString));

            DefaultCorsPolicyName = Configuration["DefaultCorsPolicyName:PolicyName"];
            string DefaultCorsPolicyUrl = Configuration["DefaultCorsPolicyName:PolicyUrl"];

            //For Cors Setting
            services.AddCors(options =>
            {
                options.AddPolicy(DefaultCorsPolicyName, p =>
                {
                    //todo: Get from configuration
                    p.WithOrigins(DefaultCorsPolicyUrl).AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();

                });
            });

            services.AddIdentity<AppUser, IdentityRole>(o =>
            {
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;

            }).AddEntityFrameworkStores<HumanitarianAssistanceDbContext>().AddDefaultTokenProviders();

            // Mediater Between Send To Handler
            services.AddMediatR(typeof(Startup));
            services.AddMediatR(typeof(GetMainLevelAccountQueryHandler).GetTypeInfo().Assembly);

            // Jwt Config
            services.AddJwtAuthentication(Configuration);


            // swagger configuration
            services.AddSwaggerDocumentation();


            //important to run your application
            services.AddMvc()
                .AddJsonOptions(config =>
                {
                    config.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
                });

            services.AddRouting();








            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // swagger configuration
            app.UseSwaggerDocumentation();

            // to use identity
            app.UseAuthentication();
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1>Humanitarian Assistance app running ... </h1>");
            });
        }
    }
}
