using Hotel_manager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotel_manager.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<RoomType> RoomTypes { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Guest> Guests { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ReservationService> ReservationServices
        { get; set; }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(
    ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ReservationService>()
                .HasKey(rs => new
                {
                    rs.ReservationId,
                    rs.ServiceId
                });

            builder.Entity<Room>()
                .HasIndex(r => r.RoomNumber)
                .IsUnique();

            // Decimal precision
            builder.Entity<Reservation>()
                .Property(r => r.TotalPrice)
                .HasPrecision(18, 2);

            builder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(18, 2);

            builder.Entity<RoomType>()
                .Property(r => r.PricePerNight)
                .HasPrecision(18, 2);

            builder.Entity<Service>()
                .Property(s => s.Price)
                .HasPrecision(18, 2);
        }
    }
}
