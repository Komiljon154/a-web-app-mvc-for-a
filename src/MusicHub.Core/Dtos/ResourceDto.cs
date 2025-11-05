namespace MusicHub.Core.Dtos;

/// <summary>
/// DTO for resource information.
/// </summary>
public class ResourceDto
{
    /// <summary> The resource's ID. </summary>
    public int Id { get; set; }
    /// <summary> The resource's name. </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary> The resource's type. </summary>
    public string Type { get; set; } = string.Empty;
}

/// <summary>
/// DTO for creating a new resource.
/// </summary>
public class CreateResourceDto
{
    /// <summary> The resource's name. </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary> The resource's type. </summary>
    public string Type { get; set; } = string.Empty;
}
