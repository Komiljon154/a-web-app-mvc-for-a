namespace MusicHub.Wpf.ViewModels;

/// <summary>
/// The main ViewModel for the application window.
/// </summary>
public class MainViewModel : ViewModelBase
{
    private ViewModelBase _currentViewModel;

    /// <summary>
    /// Gets the ViewModel for the Artists view.
    /// </summary>
    public ArtistsViewModel ArtistsVM { get; }

    /// <summary>
    /// Gets the ViewModel for the Bookings view.
    /// </summary>
    public BookingsViewModel BookingsVM { get; }

    /// <summary>
    /// Gets or sets the currently active ViewModel.
    /// </summary>
    public ViewModelBase CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            _currentViewModel = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MainViewModel"/> class.
    /// </summary>
    public MainViewModel(ArtistsViewModel artistsVM, BookingsViewModel bookingsVM)
    {
        ArtistsVM = artistsVM;
        BookingsVM = bookingsVM;
        _currentViewModel = ArtistsVM; // Set initial view
    }
}
