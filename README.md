# MusicHub: Music Streaming & Studio Booking System

This solution provides a comprehensive backend API and multiple desktop clients for a music management and studio resource booking system. It allows for managing artists, albums, and tracks, as well as scheduling appointments and booking resources like recording studios.

## Features

*   **Web API Backend:** A robust ASP.NET Core Web API to manage all data and business logic.
*   **Music Catalog Management:** Full CRUD operations for Artists, Albums, and Tracks.
*   **Resource Booking:** Functionality to list available resources (e.g., studios) and book them for specific time slots.
*   **Appointment Scheduling:** Schedule appointments with artists or producers.
*   **WPF Client:** A modern, responsive desktop application built with WPF and the MVVM pattern for a rich user experience.
*   **Windows Forms Client:** A functional, data-centric desktop application for administrative tasks.
*   **Database:** Uses Entity Framework Core with SQL Server for data persistence.
*   **Repository Pattern:** Decouples business logic from data access layers.
*   **Unit Tests:** xUnit tests for core business logic to ensure reliability.

## Getting Started

Follow these instructions to get the project up and running on your local machine.

### Prerequisites

*   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
*   Visual Studio 2022 or later (or VS Code with C# Dev Kit)
*   SQL Server (e.g., LocalDB, Express, or a full instance)

### Installation & Setup

1.  **Clone the repository:**
    ```sh
    git clone <your-repository-url>
    cd MusicHub
    ```

2.  **Restore dependencies:**
    ```sh
    dotnet restore
    ```

3.  **Configure the database connection:**
    *   Open the `src/MusicHub.Api/appsettings.json` file.
    *   Modify the `DefaultConnection` string to point to your SQL Server instance.
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MusicHubDb;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```

4.  **Apply database migrations:**
    *   Run the following command from the root `MusicHub` directory to create the database and apply the initial schema.
    ```sh
    dotnet ef database update --project src/MusicHub.Data --startup-project src/MusicHub.Api
    ```

### Running the Applications

1.  **Run the Web API:**
    *   The API must be running for the desktop clients to function.
    ```sh
    dotnet run --project src/MusicHub.Api
    ```
    *   The API will be available at `https://localhost:7123` and `http://localhost:5123`. You can browse the Swagger UI at `https://localhost:7123/swagger`.

2.  **Run the WPF Application:**
    *   Open a new terminal.
    ```sh
    dotnet run --project src/MusicHub.Wpf
    ```

3.  **Run the Windows Forms Application:**
    *   Open another new terminal.
    ```sh
    dotnet run --project src/MusicHub.WinForms
    ```

## API Endpoints

Here are the main endpoints provided by the MusicHub.Api:

*   **Artists**
    *   `GET /api/artists`: Get a list of all artists.
    *   `GET /api/artists/{id}`: Get a specific artist by ID.
    *   `POST /api/artists`: Create a new artist.
    *   `PUT /api/artists/{id}`: Update an existing artist.
    *   `DELETE /api/artists/{id}`: Delete an artist.

*   **Albums**
    *   `GET /api/artists/{artistId}/albums`: Get all albums for a specific artist.
    *   `POST /api/artists/{artistId}/albums`: Create a new album for an artist.

*   **Resources**
    *   `GET /api/resources`: Get a list of all bookable resources.
    *   `POST /api/resources`: Create a new resource.

*   **Bookings**
    *   `GET /api/bookings`: Get all bookings.
    *   `GET /api/bookings/resource/{resourceId}`: Get all bookings for a specific resource.
    *   `POST /api/bookings`: Create a new booking.

---
*This project was created by Karimov Komil.
