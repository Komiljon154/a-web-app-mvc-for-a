using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicHub.Core.Dtos;
using MusicHub.Core.Interfaces;
using MusicHub.Core.Models;

namespace MusicHub.Api.Controllers;

/// <summary>
/// API endpoints for managing bookable resources.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class ResourcesController : ControllerBase
{
    private readonly ISchedulingService _schedulingService;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="ResourcesController"/> class.
    /// </summary>
    public ResourcesController(ISchedulingService schedulingService, IMapper mapper)
    {
        _schedulingService = schedulingService;
        _mapper = mapper;
    }

    /// <summary>
    /// Gets all available resources.
    /// </summary>
    /// <returns>A list of resources.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ResourceDto>>> GetAll()
    {
        var resources = await _schedulingService.GetAllResources();
        return Ok(_mapper.Map<IEnumerable<ResourceDto>>(resources));
    }

    /// <summary>
    /// Creates a new resource.
    /// </summary>
    /// <param name="createResourceDto">The resource data.</param>
    /// <returns>The created resource.</returns>
    [HttpPost]
    public async Task<ActionResult<ResourceDto>> Create([FromBody] CreateResourceDto createResourceDto)
    {
        var resource = _mapper.Map<Resource>(createResourceDto);
        var newResource = await _schedulingService.CreateResource(resource);
        return Ok(_mapper.Map<ResourceDto>(newResource));
    }
}
