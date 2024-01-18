using AutoBooking.Application.Common.Interfaces.Authentication;
using AutoBooking.Application.Common.Interfaces.Persistence;
using AutoBooking.Application.Authentication.Common;
using AutoBooking.Domain.Entities;
using AutoBooking.Domain.Common.Errors;
using ErrorOr;
using MediatR;

namespace AutoBooking.Application.Authentication.Commands.Register
{
    public class RegisterCommandHandler : 
           IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public RegisterCommandHandler(
            IJwtTokenGenerator jwtTokenGenerator,
            IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }
        public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
            //Check if user already exists
            //1. Validate the user doesn't exist
            if (_userRepository.GetUserByPhoneNumber(command.PhoneNumber) is not null)
            {
                return Errors.User.DuplicatePhoneNumber;
            }

            //2.Create user(generate unique ID) & Persist to DB
            var user = new User
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                PhoneNumber = command.PhoneNumber
            };

            _userRepository.Add(user);

            //3.Create JWT token
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
    }
}