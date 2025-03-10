using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpiritualDevalApp.Models.Entities
{
    public class UserAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_name")]
        [MaxLength(100)]
        public string? UserName { get; set; }

        [Column("password")]
        [MaxLength(100)]
        public string? Password { get; set; }

        [Column("role")]
        [MaxLength(20)]
        public string? Role { get; set; }

        [Column("first_name")]
        [MaxLength(100)]
        public string? FirstName { get; set; }

        [Column("last_name")]
        [MaxLength(100)]
        public string? LastName { get; set; }

        [Column("email")]
        [MaxLength(100)]
        public string? Email { get; set; }

        [Column("subscribed_to_volunteer_updates")]
        public bool SubscribedToVolunteerUpdates { get; set; } = false;
    }
}