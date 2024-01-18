using AutoBooking.Domain.Entities;

namespace AutoBooking.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        User? GetUserByPhoneNumber(string phoneNumber);
        void Add(User user);
    }
    
}