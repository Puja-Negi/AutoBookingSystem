
using AutoBooking.Api.Common.Errors;
using AutoBooking.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace AutoBooking.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<ProblemDetailsFactory, AutoBookingProblemDetailsFactory>();
            services.AddMappings();
            return services;
        }
    }
}