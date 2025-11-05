using MusicHub.Core.Models;

namespace MusicHub.Core.Interfaces;

/// <summary>
/// Interface for the Unit of Work pattern.
/// </summary>
public interface IUnitOfWork : IDisposable
{
    /// <summary> Gets the repository for Artists. </summary>
    IRepository<Artist> Artists { get; }
    /// <summary> Gets the repository for Albums. </summary>
    IRepository<Album> Albums { get; }
    /// <summary> Gets the repository for Tracks. </summary>
    IRepository<Track> Tracks { get; }
    /// <summary> Gets the repository for Resources. </summary>
    IRepository<Resource> Resources { get; }
    /// <summary> Gets the repository for Bookings. </summary>
    IRepository<Booking> Bookings { get; }

    /// <summary>
    /// Completes the transaction by saving changes to the database.
    /// </summary>
    /// <returns>The number of state entries written to the database.</returns>
    Task<int> CompleteAsync();
}
