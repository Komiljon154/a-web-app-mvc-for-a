using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicHub.Core.Models;

namespace MusicHub.Data.Configurations;

/// <summary>
/// EF Core configuration for the Artist entity.
/// </summary>
public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
{
    /// <summary>
    /// Configures the entity.
    /// </summary>
    public void Configure(EntityTypeBuilder<Artist> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
        builder.HasMany(a => a.Albums).WithOne(b => b.Artist).HasForeignKey(b => b.ArtistId);

        builder.HasData(
            new Artist { Id = 1, Name = "Pink Floyd", Bio = "An English rock band formed in London in 1965." },
            new Artist { Id = 2, Name = "Led Zeppelin", Bio = "An English rock band formed in London in 1968." }
        );
    }
}
