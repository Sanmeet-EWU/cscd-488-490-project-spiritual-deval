using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpiritualDevalApp.Models.Entities
{
    public class VolunteerRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("volunteer_registration_id")]
        public int VolunteerRegistrationId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("event_id")]
        public int EventId { get; set; }

        [Column("registration_date")]
        public DateTime RegistrationDate { get; set; }

        [Column("skills_provided")]
        [MaxLength(200)]
        public string SkillsProvided { get; set; } = string.Empty;

        // Navigation properties
        public UserAccount User { get; set; }
        public Event Event { get; set; }
    }
}