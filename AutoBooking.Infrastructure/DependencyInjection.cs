using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoBooking.Application.Common.Interfaces.Authentication;
using AutoBooking.Application.Common.Interfaces.Persistence;
using AutoBooking.Application.Common.Interfaces.Services;
using AutoBooking.Infrastructure.Authentication;
using AutoBooking.Infrastructure.Persistence;
using AutoBooking.Infrastructure.Services;

namespace AutoBooking.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();  

            services.AddScoped<IUserRepository, UserRepository>();
            
            return services;
        }
    }
}