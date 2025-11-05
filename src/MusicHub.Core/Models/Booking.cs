namespace MusicHub.Core.Models;

/// <summary>
/// Represents a booking for a resource.
/// </summary>
public class Booking
{
    /// <summary>
    /// Gets or sets the unique identifier for the booking.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the foreign key for the resource being booked.
    /// </summary>
    public int ResourceId { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for the resource.
    /// </summary>
    public Resource? Resource { get; set; }

    /// <summary>
    /// Gets or sets the start time of the booking.
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// Gets or sets the end time of the booking.
    /// </summary>
    public DateTime EndTime { get; set; }

    /// <summary>
    /// Gets or sets the name or ID of the user who made the booking.
    /// </summary>
    public string BookedBy { get; set; } = string.Empty;
}
