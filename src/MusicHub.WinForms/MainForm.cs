using MusicHub.Core.Dtos;
using MusicHub.WinForms.Services;

namespace MusicHub.WinForms;

public partial class MainForm : Form
{
    private readonly ApiClient _apiClient;

    public MainForm()
    {
        InitializeComponent();
        _apiClient = new ApiClient();
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        await LoadArtists();
        await LoadResources();
        await LoadBookings();
    }

    private async Task LoadArtists()
    {
        try
        {
            var artists = await _apiClient.GetArtistsAsync();
            artistsGridView.DataSource = artists;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load artists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadResources()
    {
        try
        {
            var resources = await _apiClient.GetResourcesAsync();
            resourcesGridView.DataSource = resources;
            resourceComboBox.DataSource = resources;
            resourceComboBox.DisplayMember = "Name";
            resourceComboBox.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load resources: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadBookings()
    {
        try
        {
            var bookings = await _apiClient.GetBookingsAsync();
            bookingsGridView.DataSource = bookings;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void createBookingButton_Click(object sender, EventArgs e)
    {
        if (resourceComboBox.SelectedValue == null || string.IsNullOrWhiteSpace(bookedByTextBox.Text))
        {
            MessageBox.Show("Please select a resource and enter your name.", "Input Error");
            return;
        }

        var newBooking = new CreateBookingDto
        {
            ResourceId = (int)resourceComboBox.SelectedValue,
            BookedBy = bookedByTextBox.Text,
            StartTime = startDatePicker.Value,
            EndTime = endDatePicker.Value
        };

        try
        {
            await _apiClient.CreateBookingAsync(newBooking);
            MessageBox.Show("Booking created successfully!", "Success");
            await LoadBookings(); // Refresh the list
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to create booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
