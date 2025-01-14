
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Registration> Registrations { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Registration>()
            .HasOne(r => r.Event)
            .WithMany(e => e.Registrations)
            .HasForeignKey(r => r.EventId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete registrations when an event is deleted
        modelBuilder.Entity<Registration>()
            .HasOne(r => r.User)
            .WithMany(u => u.Registrations)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent deleting users if they are linked to registrations
    }
}
public class User
{
    public int UserId { get; set; } // Primary Key
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
    public string Password { get; set; } = string.Empty;
    [Phone]
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    // Navigation property
    public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
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
    // Navigation property
    public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
public class Registration
{
    public int RegistrationId { get; set; } // Primary Key
    [Required]
    public int EventId { get; set; } // Foreign Key to Event
    [Required]
    public int UserId { get; set; } // Foreign Key to User
    [Required]
    [RegularExpression("Attendee|Volunteer", ErrorMessage = "Role must be 'Attendee' or 'Volunteer'.")]
    public string Role { get; set; } = "Attendee";
    // Navigation properties
    public Event Event { get; set; }
    public User User { get; set; }
}
