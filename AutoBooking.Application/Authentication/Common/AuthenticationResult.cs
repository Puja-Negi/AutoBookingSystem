using AutoBooking.Domain.Entities;

namespace AutoBooking.Application.Authentication.Common
{
    public record AuthenticationResult(
       User User,
       string Token);
}
