namespace MusicHub.Core.Models;

/// <summary>
/// Represents a musical artist or band.
/// </summary>
public class Artist
{
    /// <summary>
    /// Gets or sets the unique identifier for the artist.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the artist.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the biography of the artist.
    /// </summary>
    public string? Bio { get; set; }

    /// <summary>
    /// Gets or sets the collection of albums by this artist.
    /// </summary>
    public ICollection<Album> Albums { get; set; } = new List<Album>();
}
