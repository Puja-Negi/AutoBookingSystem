using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoBooking.Domain.Entities
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        [ForeignKey("User")]
        public Guid UserId {get; set; }
        public string LicenseNumber { get; set; } = string.Empty;
        public string DriverLocation { get; set; } = string.Empty;
        public int TotalRides { get; set; }
        public bool AvailabilityStatus { get; set; }

         public User? User { get; set; }
    }
}