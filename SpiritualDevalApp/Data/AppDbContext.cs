
using Microsoft.EntityFrameworkCore;
using SpiritualDevalApp.Models.Entities;

namespace SpiritualDevalApp.Data;
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventRegistration> EventRegistrations { get; set; }
        public DbSet<VolunteerRegistration> VolunteerRegistrations { get; set; }
    }