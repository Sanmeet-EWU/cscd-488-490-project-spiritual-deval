namespace SpiritualDevalApp.Models.Entities
{
    public class Event
    {
        public int EventId { get; set; } // Primary Key
        public string EventTitle { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; } = string.Empty;
        public int MaxParticipants { get; set; }
        public int VolunteersRequired { get; set; }
        public string SkillsRequired { get; set; } = string.Empty;
    }
}