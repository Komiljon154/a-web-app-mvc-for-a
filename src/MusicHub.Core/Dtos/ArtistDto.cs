namespace MusicHub.Core.Dtos;

/// <summary>
/// DTO for artist information.
/// </summary>
public class ArtistDto
{
    /// <summary> The artist's ID. </summary>
    public int Id { get; set; }
    /// <summary> The artist's name. </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary> The artist's biography. </summary>
    public string? Bio { get; set; }
}

/// <summary>
/// DTO for creating a new artist.
/// </summary>
public class CreateArtistDto
{
    /// <summary> The artist's name. </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary> The artist's biography. </summary>
    public string? Bio { get; set; }
}

/// <summary>
/// DTO for updating an artist.
/// </summary>
public class UpdateArtistDto
{
    /// <summary> The artist's name. </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary> The artist's biography. </summary>
    public string? Bio { get; set; }
}
