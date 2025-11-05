using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicHub.Core.Dtos;
using MusicHub.Core.Interfaces;
using MusicHub.Core.Models;

namespace MusicHub.Api.Controllers;

/// <summary>
/// API endpoints for managing albums for a specific artist.
/// </summary>
[Route("api/artists/{artistId}/[controller]")]
[ApiController]
public class AlbumsController : ControllerBase
{
    private readonly IMusicService _musicService;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="AlbumsController"/> class.
    /// </summary>
    public AlbumsController(IMusicService musicService, IMapper mapper)
    {
        _musicService = musicService;
        _mapper = mapper;
    }

    /// <summary>
    /// Gets all albums for a specific artist.
    /// </summary>
    /// <param name="artistId">The ID of the artist.</param>
    /// <returns>A list of albums.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AlbumDto>>> GetAlbumsForArtist(int artistId)
    {
        var albums = await _musicService.GetAlbumsByArtist(artistId);
        return Ok(_mapper.Map<IEnumerable<AlbumDto>>(albums));
    }

    /// <summary>
    /// Creates a new album for an artist.
    /// </summary>
    /// <param name="artistId">The ID of the artist.</param>
    /// <param name="createAlbumDto">The album data.</param>
    /// <returns>The created album.</returns>
    [HttpPost]
    public async Task<ActionResult<AlbumDto>> CreateAlbumForArtist(int artistId, [FromBody] CreateAlbumDto createAlbumDto)
    {
        var album = _mapper.Map<Album>(createAlbumDto);
        album.ArtistId = artistId;
        var newAlbum = await _musicService.CreateAlbum(album);
        return Ok(_mapper.Map<AlbumDto>(newAlbum));
    }
}
