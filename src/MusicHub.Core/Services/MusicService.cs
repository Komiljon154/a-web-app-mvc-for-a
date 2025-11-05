using MusicHub.Core.Interfaces;
using MusicHub.Core.Models;

namespace MusicHub.Core.Services;

/// <summary>
/// Implementation of the music management service.
/// </summary>
public class MusicService : IMusicService
{
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// Initializes a new instance of the <see cref="MusicService"/> class.
    /// </summary>
    public MusicService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Artist> CreateArtist(Artist newArtist)
    {
        await _unitOfWork.Artists.AddAsync(newArtist);
        await _unitOfWork.CompleteAsync();
        return newArtist;
    }

    public async Task DeleteArtist(int id)
    {
        var artist = await _unitOfWork.Artists.GetByIdAsync(id);
        if (artist != null)
        {
            _unitOfWork.Artists.Remove(artist);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task<IEnumerable<Artist>> GetAllArtists()
    {
        return await _unitOfWork.Artists.GetAllAsync();
    }

    public async Task<Artist?> GetArtistById(int id)
    {
        return await _unitOfWork.Artists.GetByIdAsync(id);
    }

    public async Task UpdateArtist(Artist artistToUpdate)
    {
        // The repository is tracked, so just need to save changes.
        await _unitOfWork.CompleteAsync();
    }

    public async Task<IEnumerable<Album>> GetAlbumsByArtist(int artistId)
    {
        return _unitOfWork.Albums.Find(a => a.ArtistId == artistId);
    }

    public async Task<Album> CreateAlbum(Album newAlbum)
    {
        await _unitOfWork.Albums.AddAsync(newAlbum);
        await _unitOfWork.CompleteAsync();
        return newAlbum;
    }
}
