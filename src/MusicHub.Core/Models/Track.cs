namespace MusicHub.Core.Models;

/// <summary>
/// Represents a single track on an album.
/// </summary>
public class Track
{
    /// <summary>
    /// Gets or sets the unique identifier for the track.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title of the track.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the duration of the track.
    /// </summary>
    public TimeSpan Duration { get; set; }

    /// <summary>
    /// Gets or sets the foreign key for the album.
    /// </summary>
    public int AlbumId { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for the album.
    /// </summary>
    public Album? Album { get; set; }
}
