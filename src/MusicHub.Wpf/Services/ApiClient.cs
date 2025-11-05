using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using MusicHub.Core.Dtos;

namespace MusicHub.Wpf.Services;

/// <summary>
/// Typed HttpClient for interacting with the MusicHub API.
/// </summary>
public class ApiClient
{
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient"/> class.
    /// </summary>
    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ArtistDto>?> GetArtistsAsync() =>
        await _httpClient.GetFromJsonAsync<List<ArtistDto>>("artists");

    public async Task<List<ResourceDto>?> GetResourcesAsync() =>
        await _httpClient.GetFromJsonAsync<List<ResourceDto>>("resources");

    public async Task<List<BookingDto>?> GetBookingsAsync() =>
        await _httpClient.GetFromJsonAsync<List<BookingDto>>("bookings");

    public async Task<BookingDto?> CreateBookingAsync(CreateBookingDto booking)
    {
        var response = await _httpClient.PostAsJsonAsync("bookings", booking);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<BookingDto>();
        }
        // Optionally handle non-success status codes
        return null;
    }
}
