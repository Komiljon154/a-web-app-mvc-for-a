using Microsoft.EntityFrameworkCore;
using MusicHub.Core.Models;
using MusicHub.Data.Configurations;

namespace MusicHub.Data;

/// <summary>
/// The Entity Framework database context for the MusicHub application.
/// </summary>
public class MusicHubDbContext : DbContext
{
    /// <summary> Gets or sets the DbSet for Artists. </summary>
    public DbSet<Artist> Artists { get; set; } = null!;
    /// <summary> Gets or sets the DbSet for Albums. </summary>
    public DbSet<Album> Albums { get; set; } = null!;
    /// <summary> Gets or sets the DbSet for Tracks. </summary>
    public DbSet<Track> Tracks { get; set; } = null!;
    /// <summary> Gets or sets the DbSet for Resources. </summary>
    public DbSet<Resource> Resources { get; set; } = null!;
    /// <summary> Gets or sets the DbSet for Bookings. </summary>
    public DbSet<Booking> Bookings { get; set; } = null!;

    /// <summary>
    /// Initializes a new instance of the <see cref="MusicHubDbContext"/> class.
    /// </summary>
    public MusicHubDbContext(DbContextOptions<MusicHubDbContext> options)
        : base(options)
    { }

    /// <summary>
    /// Configures the model relationships and constraints.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ArtistConfiguration());
        builder.ApplyConfiguration(new AlbumConfiguration());
        builder.ApplyConfiguration(new ResourceConfiguration());
        builder.ApplyConfiguration(new BookingConfiguration());
    }
}
