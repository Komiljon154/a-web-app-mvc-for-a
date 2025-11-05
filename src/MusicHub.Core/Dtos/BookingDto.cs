namespace MusicHub.Core.Dtos;

/// <summary>
/// DTO for booking information.
/// </summary>
public class BookingDto
{
    /// <summary> The booking's ID. </summary>
    public int Id { get; set; }
    /// <summary> The ID of the booked resource. </summary>
    public int ResourceId { get; set; }
    /// <summary> The name of the booked resource. </summary>
    public string ResourceName { get; set; } = string.Empty;
    /// <summary> The booking start time. </summary>
    public DateTime StartTime { get; set; }
    /// <summary> The booking end time. </summary>
    public DateTime EndTime { get; set; }
    /// <summary> The user who made the booking. </summary>
    public string BookedBy { get; set; } = string.Empty;
}

/// <summary>
/// DTO for creating a new booking.
/// </summary>
public class CreateBookingDto
{
    /// <summary> The ID of the resource to book. </summary>
    public int ResourceId { get; set; }
    /// <summary> The booking start time. </summary>
    public DateTime StartTime { get; set; }
    /// <summary> The booking end time. </summary>
    public DateTime EndTime { get; set; }
    /// <summary> The user making the booking. </summary>
    public string BookedBy { get; set; } = string.Empty;
}
