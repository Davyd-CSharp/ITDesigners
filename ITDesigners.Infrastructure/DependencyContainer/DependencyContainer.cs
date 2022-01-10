using ITDesigners.Application.Interfaces;
using ITDesigners.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ITDesigners.Infrastructure.DependencyContainer
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddEmailService(this IServiceCollection services) 
        {
            services.AddTransient<IEmailService, EmailService>();
            return services;
        }
        public static IServiceCollection AddEmailValidator(this IServiceCollection services) 
        {
            services.AddTransient<IEmailValidator, EmailValidator>();
            return services;
        }

    }
}
