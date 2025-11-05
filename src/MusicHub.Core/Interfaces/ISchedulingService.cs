using MusicHub.Core.Models;

namespace MusicHub.Core.Interfaces;

/// <summary>
/// Service for managing resource bookings and appointments.
/// </summary>
public interface ISchedulingService
{
    /// <summary> Gets all resources. </summary>
    Task<IEnumerable<Resource>> GetAllResources();
    /// <summary> Creates a new resource. </summary>
    Task<Resource> CreateResource(Resource newResource);
    /// <summary> Gets all bookings. </summary>
    Task<IEnumerable<Booking>> GetAllBookings();
    /// <summary> Gets all bookings for a specific resource. </summary>
    Task<IEnumerable<Booking>> GetBookingsByResource(int resourceId);
    /// <summary> Creates a new booking. </summary>
    Task<Booking> CreateBooking(Booking newBooking);
}
