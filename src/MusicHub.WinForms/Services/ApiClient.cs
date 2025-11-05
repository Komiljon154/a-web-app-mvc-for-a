using System.Net.Http.Json;
using MusicHub.Core.Dtos;

namespace MusicHub.WinForms.Services;

/// <summary>
/// Client for interacting with the MusicHub API.
/// </summary>
public class ApiClient
{
    private readonly HttpClient _httpClient;
    private const string ApiBaseUrl = "https://localhost:7123/api"; // Ensure this matches your API's URL

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient"/> class.
    /// </summary>
    public ApiClient()
    {
        _httpClient = new HttpClient();
    }

    // Artist methods
    public async Task<List<ArtistDto>?> GetArtistsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<ArtistDto>>($"{ApiBaseUrl}/artists");
    }

    // Resource methods
    public async Task<List<ResourceDto>?> GetResourcesAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<ResourceDto>>($"{ApiBaseUrl}/resources");
    }

    // Booking methods
    public async Task<List<BookingDto>?> GetBookingsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<BookingDto>>($"{ApiBaseUrl}/bookings");
    }

    public async Task<BookingDto?> CreateBookingAsync(CreateBookingDto booking)
    {
        var response = await _httpClient.PostAsJsonAsync($"{ApiBaseUrl}/bookings", booking);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<BookingDto>();
    }
}
