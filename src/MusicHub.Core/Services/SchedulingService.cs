using MusicHub.Core.Interfaces;
using MusicHub.Core.Models;

namespace MusicHub.Core.Services;

/// <summary>
/// Implementation of the scheduling service.
/// </summary>
public class SchedulingService : ISchedulingService
{
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulingService"/> class.
    /// </summary>
    public SchedulingService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Resource>> GetAllResources()
    {
        return await _unitOfWork.Resources.GetAllAsync();
    }

    public async Task<Resource> CreateResource(Resource newResource)
    {
        await _unitOfWork.Resources.AddAsync(newResource);
        await _unitOfWork.CompleteAsync();
        return newResource;
    }

    public async Task<IEnumerable<Booking>> GetAllBookings()
    {
        return await _unitOfWork.Bookings.GetAllAsync();
    }

    public async Task<IEnumerable<Booking>> GetBookingsByResource(int resourceId)
    {
        return _unitOfWork.Bookings.Find(b => b.ResourceId == resourceId);
    }

    public async Task<Booking> CreateBooking(Booking newBooking)
    {
        var existingBookings = _unitOfWork.Bookings.Find(b =>
            b.ResourceId == newBooking.ResourceId &&
            b.EndTime > newBooking.StartTime &&
            b.StartTime < newBooking.EndTime);

        if (existingBookings.Any())
        {
            throw new InvalidOperationException("The resource is already booked for the selected time slot.");
        }

        await _unitOfWork.Bookings.AddAsync(newBooking);
        await _unitOfWork.CompleteAsync();
        return newBooking;
    }
}
