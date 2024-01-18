using AutoBooking.Api;
using AutoBooking.Api.Common.Errors;
using AutoBooking.Application;
using AutoBooking.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services
         .AddPresentation()
         .AddApplication()
         .AddInfrastructure(builder.Configuration);
}
var app = builder.Build();

// Configure the HTTP request pipeline..

{
    app.UseExceptionHandler("/error");
    
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}