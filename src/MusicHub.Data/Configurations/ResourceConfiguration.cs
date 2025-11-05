using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicHub.Core.Models;

namespace MusicHub.Data.Configurations;

/// <summary>
/// EF Core configuration for the Resource entity.
/// </summary>
public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
{
    /// <summary>
    /// Configures the entity.
    /// </summary>
    public void Configure(EntityTypeBuilder<Resource> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
        builder.Property(r => r.Type).IsRequired().HasMaxLength(50);

        builder.HasData(
            new Resource { Id = 1, Name = "Studio A", Type = "Recording Studio" },
            new Resource { Id = 2, Name = "Studio B", Type = "Recording Studio" },
            new Resource { Id = 3, Name = "Mixing Room 1", Type = "Mixing Room" }
        );
    }
}
