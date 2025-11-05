using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicHub.Core.Dtos;
using MusicHub.Core.Interfaces;
using MusicHub.Core.Models;

namespace MusicHub.Api.Controllers;

/// <summary>
/// API endpoints for managing resource bookings.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class BookingsController : ControllerBase
{
    private readonly ISchedulingService _schedulingService;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="BookingsController"/> class.
    /// </summary>
    public BookingsController(ISchedulingService schedulingService, IMapper mapper)
    {
        _schedulingService = schedulingService;
        _mapper = mapper;
    }

    /// <summary>
    /// Gets all bookings.
    /// </summary>
    /// <returns>A list of all bookings.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookingDto>>> GetAll()
    {
        var bookings = await _schedulingService.GetAllBookings();
        return Ok(_mapper.Map<IEnumerable<BookingDto>>(bookings));
    }

    /// <summary>
    /// Gets all bookings for a specific resource.
    /// </summary>
    /// <param name="resourceId">The ID of the resource.</param>
    /// <returns>A list of bookings for the resource.</returns>
    [HttpGet("resource/{resourceId}")]
    public async Task<ActionResult<IEnumerable<BookingDto>>> GetByResource(int resourceId)
    {
        var bookings = await _schedulingService.GetBookingsByResource(resourceId);
        return Ok(_mapper.Map<IEnumerable<BookingDto>>(bookings));
    }

    /// <summary>
    /// Creates a new booking.
    /// </summary>
    /// <param name="createBookingDto">The booking data.</param>
    /// <returns>The created booking.</returns>
    [HttpPost]
    public async Task<ActionResult<BookingDto>> Create([FromBody] CreateBookingDto createBookingDto)
    {
        try
        {
            var booking = _mapper.Map<Booking>(createBookingDto);
            var newBooking = await _schedulingService.CreateBooking(booking);
            return Ok(_mapper.Map<BookingDto>(newBooking));
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(new { message = ex.Message });
        }
    }
}
