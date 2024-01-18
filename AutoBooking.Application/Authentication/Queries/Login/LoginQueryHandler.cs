using AutoBooking.Application.Common.Interfaces.Authentication;
using AutoBooking.Application.Common.Interfaces.Persistence;
using AutoBooking.Domain.Entities;
using AutoBooking.Domain.Common.Errors;
using ErrorOr;
using MediatR;
using AutoBooking.Application.Authentication.Common;

namespace AutoBooking.Application.Authentication.Queries.Login
{
    public class LoginQueryHandler : 
           IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public LoginQueryHandler(
            IJwtTokenGenerator jwtTokenGenerator,
            IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            //1. Validate the user exists
            if(_userRepository.GetUserByPhoneNumber(query.PhoneNumber) is not User user)
            {
                return Errors.Authentication.InvalidCredentials;
            }

            //3.Create JWT token
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
    }
}