using AutoBooking.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace AutoBooking.Application.Authentication.Commands.Register
{
    public record RegisterCommand(
       string FirstName,
       string LastName,
       string PhoneNumber) : IRequest<ErrorOr<AuthenticationResult>>;
}
