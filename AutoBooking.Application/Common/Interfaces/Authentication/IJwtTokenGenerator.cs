using AutoBooking.Domain.Entities;

namespace AutoBooking.Application.Common.Interfaces.Authentication 
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}