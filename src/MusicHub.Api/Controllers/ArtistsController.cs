using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicHub.Core.Dtos;
using MusicHub.Core.Interfaces;
using MusicHub.Core.Models;

namespace MusicHub.Api.Controllers;

/// <summary>
/// API endpoints for managing artists.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class ArtistsController : ControllerBase
{
    private readonly IMusicService _musicService;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="ArtistsController"/> class.
    /// </summary>
    public ArtistsController(IMusicService musicService, IMapper mapper)
    {
        _musicService = musicService;
        _mapper = mapper;
    }

    /// <summary>
    /// Gets all artists.
    /// </summary>
    /// <returns>A list of artists.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ArtistDto>>> GetAll()
    {
        var artists = await _musicService.GetAllArtists();
        return Ok(_mapper.Map<IEnumerable<ArtistDto>>(artists));
    }

    /// <summary>
    /// Gets a specific artist by their ID.
    /// </summary>
    /// <param name="id">The artist ID.</param>
    /// <returns>The artist details.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<ArtistDto>> GetById(int id)
    {
        var artist = await _musicService.GetArtistById(id);
        if (artist == null) return NotFound();
        return Ok(_mapper.Map<ArtistDto>(artist));
    }

    /// <summary>
    /// Creates a new artist.
    /// </summary>
    /// <param name="createArtistDto">The artist data.</param>
    /// <returns>The created artist.</returns>
    [HttpPost]
    public async Task<ActionResult<ArtistDto>> Create([FromBody] CreateArtistDto createArtistDto)
    {
        var artist = _mapper.Map<Artist>(createArtistDto);
        var newArtist = await _musicService.CreateArtist(artist);
        var artistDto = _mapper.Map<ArtistDto>(newArtist);
        return CreatedAtAction(nameof(GetById), new { id = artistDto.Id }, artistDto);
    }

    /// <summary>
    /// Updates an existing artist.
    /// </summary>
    /// <param name="id">The ID of the artist to update.</param>
    /// <param name="updateArtistDto">The updated artist data.</param>
    /// <returns>An empty response.</returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateArtistDto updateArtistDto)
    {
        var artistToUpdate = await _musicService.GetArtistById(id);
        if (artistToUpdate == null) return NotFound();

        _mapper.Map(updateArtistDto, artistToUpdate);
        await _musicService.UpdateArtist(artistToUpdate);
        return NoContent();
    }

    /// <summary>
    /// Deletes an artist.
    /// </summary>
    /// <param name="id">The ID of the artist to delete.</param>
    /// <returns>An empty response.</returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var artistToDelete = await _musicService.GetArtistById(id);
        if (artistToDelete == null) return NotFound();

        await _musicService.DeleteArtist(id);
        return NoContent();
    }
}
