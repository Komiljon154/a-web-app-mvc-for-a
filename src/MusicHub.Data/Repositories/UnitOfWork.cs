using MusicHub.Core.Interfaces;
using MusicHub.Core.Models;

namespace MusicHub.Data.Repositories;

/// <summary>
/// Unit of Work implementation.
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    private readonly MusicHubDbContext _context;
    private Repository<Artist>? _artistRepository;
    private Repository<Album>? _albumRepository;
    private Repository<Track>? _trackRepository;
    private Repository<Resource>? _resourceRepository;
    private Repository<Booking>? _bookingRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
    /// </summary>
    public UnitOfWork(MusicHubDbContext context)
    {
        _context = context;
    }

    public IRepository<Artist> Artists => _artistRepository ??= new Repository<Artist>(_context);
    public IRepository<Album> Albums => _albumRepository ??= new Repository<Album>(_context);
    public IRepository<Track> Tracks => _trackRepository ??= new Repository<Track>(_context);
    public IRepository<Resource> Resources => _resourceRepository ??= new Repository<Resource>(_context);
    public IRepository<Booking> Bookings => _bookingRepository ??= new Repository<Booking>(_context);

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}
