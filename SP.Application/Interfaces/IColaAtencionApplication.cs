using SP.Application.Commons.Base;
using SP.Application.Dtos.Request;
using SP.Application.Dtos.Response;
using SP.Infrastructure.Commons.Base.Request;
using SP.Infrastructure.Commons.Base.Response;

namespace SP.Application.Interfaces
{
    public interface IColaAtencionApplication
    {
        Task<BaseResponse<BaseEntityResponse<ColaAtencionResponseDto>>> lstCasos(BaseFiltersRequest filtros);
        Task<BaseResponse<IEnumerable<ColaAtencionSelectResponseDto>>> lstSelectCasos();
        Task<BaseResponse<ColaAtencionResponseDto>> CasoById(decimal Id);
        Task<BaseResponse<bool>> RegistroCaso(ColaAtencionRequestDto requestDto);
        Task<BaseResponse<bool>> EditarCaso(decimal Id, ColaAtencionRequestDto requestDto);
        Task<BaseResponse<bool>> BorrarCaso(decimal Id);
    }
}
