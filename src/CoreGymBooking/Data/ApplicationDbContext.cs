using CoreGymBooking.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreGymBooking.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<TrainingClass> TrainingClasses => Set<TrainingClass>();

    public DbSet<Booking> Bookings => Set<Booking>();

    public DbSet<UserProfile> UserProfiles => Set<UserProfile>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Samma användare ska bara kunna ha en bokning per träningspass.
        builder.Entity<Booking>()
            .HasIndex(booking => new { booking.UserId, booking.TrainingClassId })
            .IsUnique();

        // Varje användare har högst en profil.
        builder.Entity<UserProfile>()
            .HasIndex(profile => profile.UserId)
            .IsUnique();
    }
}
