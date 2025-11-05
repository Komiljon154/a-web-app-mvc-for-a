using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MusicHub.Core.Dtos;
using MusicHub.Wpf.Services;

namespace MusicHub.Wpf.ViewModels;

/// <summary>
/// ViewModel for managing and displaying artists.
/// </summary>
public class ArtistsViewModel : ViewModelBase
{
    private readonly ApiClient _apiClient;

    /// <summary>
    /// Gets the collection of artists.
    /// </summary>
    public ObservableCollection<ArtistDto> Artists { get; } = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="ArtistsViewModel"/> class.
    /// </summary>
    public ArtistsViewModel(ApiClient apiClient)
    {
        _apiClient = apiClient;
        LoadArtistsAsync();
    }

    private async Task LoadArtistsAsync()
    {
        var artists = await _apiClient.GetArtistsAsync();
        if (artists != null)
        {
            Artists.Clear();
            foreach (var artist in artists)
            {
                Artists.Add(artist);
            }
        }
    }
}
