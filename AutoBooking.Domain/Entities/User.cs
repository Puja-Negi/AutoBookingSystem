using System.ComponentModel.DataAnnotations;

namespace AutoBooking.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid UserId {get; set; } = Guid.NewGuid();
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsDriver { get; set; }
        public bool IsAdmin { get; set; }
    }
}