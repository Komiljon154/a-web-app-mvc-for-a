using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicHub.Core.Models;

namespace MusicHub.Data.Configurations;

/// <summary>
/// EF Core configuration for the Booking entity.
/// </summary>
public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    /// <summary>
    /// Configures the entity.
    /// </summary>
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.BookedBy).IsRequired().HasMaxLength(100);
        builder.HasOne(b => b.Resource).WithMany(r => r.Bookings).HasForeignKey(b => b.ResourceId);

        builder.HasData(
            new Booking { Id = 1, ResourceId = 1, StartTime = DateTime.UtcNow.Date.AddHours(10), EndTime = DateTime.UtcNow.Date.AddHours(14), BookedBy = "John Doe" }
        );
    }
}
