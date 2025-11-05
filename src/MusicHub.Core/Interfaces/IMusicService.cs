using MusicHub.Core.Models;

namespace MusicHub.Core.Interfaces;

/// <summary>
/// Service for managing music catalog (artists, albums, tracks).
/// </summary>
public interface IMusicService
{
    /// <summary> Gets all artists. </summary>
    Task<IEnumerable<Artist>> GetAllArtists();
    /// <summary> Gets an artist by ID. </summary>
    Task<Artist?> GetArtistById(int id);
    /// <summary> Creates a new artist. </summary>
    Task<Artist> CreateArtist(Artist newArtist);
    /// <summary> Updates an existing artist. </summary>
    Task UpdateArtist(Artist artistToUpdate);
    /// <summary> Deletes an artist. </summary>
    Task DeleteArtist(int id);
    /// <summary> Gets all albums for a given artist. </summary>
    Task<IEnumerable<Album>> GetAlbumsByArtist(int artistId);
    /// <summary> Creates a new album. </summary>
    Task<Album> CreateAlbum(Album newAlbum);
}
