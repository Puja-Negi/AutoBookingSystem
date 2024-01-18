using AutoBooking.Application.Authentication.Commands.Register;
using AutoBooking.Application.Authentication.Common;
using AutoBooking.Application.Authentication.Queries.Login;
using AutoBooking.Contracts.Authentication.User;
using Mapster;
using Microsoft.AspNetCore.Identity.Data;

namespace AutoBooking.Api.Common.Mapping
{
    public class AuthenticationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<RegisterRequest, RegisterCommand>();

            config.NewConfig<LoginRequest, LoginQuery>();
            
            config.NewConfig<AuthenticationResult, AuthenticationResponse>()
                .Map(dest => dest, src => src.User);
        }
    }
}