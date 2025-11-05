using Moq;
using MusicHub.Core.Interfaces;
using MusicHub.Core.Models;
using MusicHub.Core.Services;
using System.Linq.Expressions;

namespace MusicHub.Core.Tests;

public class SchedulingServiceTests
{
    private readonly Mock<IUnitOfWork> _mockUnitOfWork;
    private readonly Mock<IRepository<Booking>> _mockBookingRepo;
    private readonly SchedulingService _service;

    public SchedulingServiceTests()
    {
        _mockUnitOfWork = new Mock<IUnitOfWork>();
        _mockBookingRepo = new Mock<IRepository<Booking>>();
        _mockUnitOfWork.Setup(uow => uow.Bookings).Returns(_mockBookingRepo.Object);
        _service = new SchedulingService(_mockUnitOfWork.Object);
    }

    [Fact]
    public async Task CreateBooking_WhenSlotIsFree_ShouldSucceed()
    {
        // Arrange
        var newBooking = new Booking
        {
            ResourceId = 1,
            StartTime = new DateTime(2024, 1, 1, 10, 0, 0),
            EndTime = new DateTime(2024, 1, 1, 12, 0, 0)
        };

        _mockBookingRepo.Setup(repo => repo.Find(It.IsAny<Expression<Func<Booking, bool>>>()))
                        .Returns(new List<Booking>().AsQueryable());

        // Act
        var result = await _service.CreateBooking(newBooking);

        // Assert
        _mockBookingRepo.Verify(repo => repo.AddAsync(newBooking), Times.Once);
        _mockUnitOfWork.Verify(uow => uow.CompleteAsync(), Times.Once);
        Assert.NotNull(result);
    }

    [Fact]
    public async Task CreateBooking_WhenSlotIsTaken_ShouldThrowException()
    {
        // Arrange
        var existingBooking = new Booking
        {
            ResourceId = 1,
            StartTime = new DateTime(2024, 1, 1, 9, 0, 0),
            EndTime = new DateTime(2024, 1, 1, 11, 0, 0)
        };

        var newBooking = new Booking
        {
            ResourceId = 1,
            StartTime = new DateTime(2024, 1, 1, 10, 0, 0),
            EndTime = new DateTime(2024, 1, 1, 12, 0, 0)
        };

        _mockBookingRepo.Setup(repo => repo.Find(It.IsAny<Expression<Func<Booking, bool>>>()))
                        .Returns(new List<Booking> { existingBooking }.AsQueryable());

        // Act & Assert
        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => _service.CreateBooking(newBooking));
        Assert.Equal("The resource is already booked for the selected time slot.", exception.Message);
        _mockBookingRepo.Verify(repo => repo.AddAsync(It.IsAny<Booking>()), Times.Never);
        _mockUnitOfWork.Verify(uow => uow.CompleteAsync(), Times.Never);
    }
}
