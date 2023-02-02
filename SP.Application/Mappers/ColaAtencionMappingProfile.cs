using AutoMapper;
using SP.Application.Dtos.Response;
using SP.Domain.Entities;
using SP.Infrastructure.Commons.Base.Response;
using SP.Utilities.Static;

namespace SP.Application.Mappers
{
    public class ColaAtencionMappingProfile : Profile
    {
        public ColaAtencionMappingProfile()
        {
            CreateMap<ColaAtencionMappingProfile, ColaAtencionResponseDto>()
                .ForMember(x => x.Estado, x => x.MapFrom(y => y.Equals(TiposEstado.A) ? "Activo" : "Inactivo"))
                .ReverseMap();

            CreateMap<BaseEntityResponse<ColaAtencion>, BaseEntityResponse<ColaAtencionResponseDto>>()
                .ReverseMap();

            CreateMap<ColaAtencionResponseDto, ColaAtencion>();

            CreateMap<ColaAtencion, ColaAtencionSelectResponseDto>()
                .ReverseMap();
        }
    }
}
