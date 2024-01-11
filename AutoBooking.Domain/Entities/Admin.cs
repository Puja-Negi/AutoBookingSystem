using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoBooking.Domain.Entities
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [ForeignKey("User")]
        public Guid UserId {get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

         public User User { get; set; }
    }
}