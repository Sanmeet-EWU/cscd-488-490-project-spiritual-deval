using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpiritualDevalApp.Models.Entities
{
    public class EventRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("event_registration_id")]
        public int EventRegistrationId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("event_id")]
        public int EventId { get; set; }

        [Column("registration_date")]
        public DateTime RegistrationDate { get; set; }

        // Navigation properties
        public UserAccount User { get; set; }
        public Event Event { get; set; }
    }
}