
using AutoBooking.Application.Common.Interfaces.Persistence;
using AutoBooking.Domain.Entities;

namespace AutoBooking.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _user = new();
        public void Add(User user)
        {
           _user.Add(user);
        }

        public User? GetUserByPhoneNumber(string phoneNumber)
        {
            return _user.SingleOrDefault(u => u.PhoneNumber == phoneNumber); 
        }
    }

}