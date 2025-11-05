namespace MusicHub.Core.Models;

/// <summary>
/// Represents a music album.
/// </summary>
public class Album
{
    /// <summary>
    /// Gets or sets the unique identifier for the album.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title of the album.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the release date of the album.
    /// </summary>
    public DateTime ReleaseDate { get; set; }

    /// <summary>
    /// Gets or sets the foreign key for the artist.
    /// </summary>
    public int ArtistId { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for the artist.
    /// </summary>
    public Artist? Artist { get; set; }

    /// <summary>
    /// Gets or sets the collection of tracks in this album.
    /// </summary>
    public ICollection<Track> Tracks { get; set; } = new List<Track>();
}
