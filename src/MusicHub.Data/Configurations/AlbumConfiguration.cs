using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicHub.Core.Models;

namespace MusicHub.Data.Configurations;

/// <summary>
/// EF Core configuration for the Album entity.
/// </summary>
public class AlbumConfiguration : IEntityTypeConfiguration<Album>
{
    /// <summary>
    /// Configures the entity.
    /// </summary>
    public void Configure(EntityTypeBuilder<Album> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Title).IsRequired().HasMaxLength(150);
        builder.HasMany(a => a.Tracks).WithOne(t => t.Album).HasForeignKey(t => t.AlbumId);

        builder.HasData(
            new Album { Id = 1, Title = "The Dark Side of the Moon", ReleaseDate = new DateTime(1973, 3, 1), ArtistId = 1 },
            new Album { Id = 2, Title = "Wish You Were Here", ReleaseDate = new DateTime(1975, 9, 12), ArtistId = 1 },
            new Album { Id = 3, Title = "Led Zeppelin IV", ReleaseDate = new DateTime(1971, 11, 8), ArtistId = 2 }
        );
    }
}
