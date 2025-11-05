namespace MusicHub.Core.Models;

/// <summary>
/// Represents a bookable resource, such as a recording studio.
/// </summary>
public class Resource
{
    /// <summary>
    /// Gets or sets the unique identifier for the resource.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the resource (e.g., "Studio A").
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the type of the resource (e.g., "Recording Studio", "Mixing Room").
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the collection of bookings for this resource.
    /// </summary>
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
