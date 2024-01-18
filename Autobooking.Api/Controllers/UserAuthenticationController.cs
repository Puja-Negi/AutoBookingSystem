using Microsoft.AspNetCore.Mvc;
using AutoBooking.Contracts.Authentication.User;
using MediatR;
using AutoBooking.Application.Authentication.Queries.Login;
using AutoBooking.Application.Authentication.Commands.Register;
using AutoBooking.Application.Authentication.Common;
using ErrorOr;
using MapsterMapper;

namespace AutoBooking.Api.Controllers
{
    [Route("auth")]
    public class UserAuthenticationController : BaseController
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;
        public UserAuthenticationController(
            ISender mediator,
            IMapper mapper) 
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpPost("register")]
        public async Task<IActionResult> UserRegister(UserRegisterRequest request)
        {
            var command = _mapper.Map<RegisterCommand>(request);
            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);

            return authResult.Match(
                authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
                errors => Problem(errors));
        }

        [HttpPost("login")]
        public async Task<IActionResult> UserLogin(UserLoginRequest request)
        {
            
            var query = _mapper.Map<LoginQuery>(request);
            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(query);

            return authResult.Match(
                authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
                errors => Problem(errors));
        }
      
    }
}
