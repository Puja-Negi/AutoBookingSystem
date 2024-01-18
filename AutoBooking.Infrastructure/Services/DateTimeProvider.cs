using AutoBooking.Application.Common.Interfaces.Services;

namespace AutoBooking.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}