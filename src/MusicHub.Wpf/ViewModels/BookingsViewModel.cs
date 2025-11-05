using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MusicHub.Core.Dtos;
using MusicHub.Wpf.Services;

namespace MusicHub.Wpf.ViewModels;

/// <summary>
/// ViewModel for managing and displaying bookings.
/// </summary>
public class BookingsViewModel : ViewModelBase
{
    private readonly ApiClient _apiClient;

    /// <summary>
    /// Gets the collection of bookings.
    /// </summary>
    public ObservableCollection<BookingDto> Bookings { get; } = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="BookingsViewModel"/> class.
    /// </summary>
    public BookingsViewModel(ApiClient apiClient)
    {
        _apiClient = apiClient;
        LoadBookingsAsync();
    }

    private async Task LoadBookingsAsync()
    {
        var bookings = await _apiClient.GetBookingsAsync();
        if (bookings != null)
        {
            Bookings.Clear();
            foreach (var booking in bookings)
            {
                Bookings.Add(booking);
            }
        }
    }
}
