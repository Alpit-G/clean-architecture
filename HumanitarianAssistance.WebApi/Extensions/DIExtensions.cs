using Microsoft.Extensions.DependencyInjection;

namespace HumanitarianAssistance.WebApi.Extensions
{
     public static class DIExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {

            // services.AddTransient<IOfficeDetails, OfficeDetailsService>();

            return services;
        }  
    }
}