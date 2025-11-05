namespace MusicHub.Core.Dtos;

/// <summary>
/// DTO for album information.
/// </summary>
public class AlbumDto
{
    /// <summary> The album's ID. </summary>
    public int Id { get; set; }
    /// <summary> The album's title. </summary>
    public string Title { get; set; } = string.Empty;
    /// <summary> The album's release date. </summary>
    public DateTime ReleaseDate { get; set; }
}

/// <summary>
/// DTO for creating a new album.
/// </summary>
public class CreateAlbumDto
{
    /// <summary> The album's title. </summary>
    public string Title { get; set; } = string.Empty;
    /// <summary> The album's release date. </summary>
    public DateTime ReleaseDate { get; set; }
}
