using AutoMapper;
using MusicHub.Core.Dtos;
using MusicHub.Core.Models;

namespace MusicHub.Core.Mapping;

/// <summary>
/// AutoMapper profile for mapping between entities and DTOs.
/// </summary>
public class MappingProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MappingProfile"/> class.
    /// </summary>
    public MappingProfile()
    {
        // Artist Mappings
        CreateMap<Artist, ArtistDto>();
        CreateMap<CreateArtistDto, Artist>();
        CreateMap<UpdateArtistDto, Artist>();

        // Album Mappings
        CreateMap<Album, AlbumDto>();
        CreateMap<CreateAlbumDto, Album>();

        // Resource Mappings
        CreateMap<Resource, ResourceDto>();
        CreateMap<CreateResourceDto, Resource>();

        // Booking Mappings
        CreateMap<Booking, BookingDto>()
            .ForMember(dest => dest.ResourceName, opt => opt.MapFrom(src => src.Resource != null ? src.Resource.Name : string.Empty));
        CreateMap<CreateBookingDto, Booking>();
    }
}
