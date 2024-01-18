using AutoBooking.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace AutoBooking.Application.Authentication.Queries.Login
{
    public record LoginQuery(
       string PhoneNumber) : IRequest<ErrorOr<AuthenticationResult>>;
}
