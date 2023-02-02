using AutoMapper;
using SP.Application.Commons.Base;
using SP.Application.Dtos.Request;
using SP.Application.Dtos.Response;
using SP.Application.Interfaces;
using SP.Application.Validators.ColaAtencion;
using SP.Infrastructure.Commons.Base.Request;
using SP.Infrastructure.Commons.Base.Response;
using SP.Infrastructure.Persistences.Interfaces;
using SP.Utilities.Static;

namespace SP.Application.Services
{
    public class ColaAtencionApplication : IColaAtencionApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ColaAtencionValidacion _validationRules;

        public ColaAtencionApplication(IUnitOfWork unitOfWork, IMapper mapper, ColaAtencionValidacion validationRules)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validationRules = validationRules;
        }
        public async Task<BaseResponse<BaseEntityResponse<ColaAtencionResponseDto>>> lstCasos(BaseFiltersRequest filtros)
        {
            var response = new BaseResponse<BaseEntityResponse<ColaAtencionResponseDto>>();
            var casos = await _unitOfWork.ColaAtencion.ListaColaAtencion(filtros);
            if(casos != null)
            {
                response.IsSuccess = true;
                response.Data = _mapper.Map<BaseEntityResponse<ColaAtencionResponseDto>>(casos);
                response.Mensaje = MsgRespuesta.MESSAGE_QUERY;
            }
            else
            {
                response.IsSuccess = false;
                response.Mensaje = MsgRespuesta.MESSAGE_QUERY_EMPTY;
            }

            return response;
        }
        public async Task<BaseResponse<IEnumerable<ColaAtencionSelectResponseDto>>> lstSelectCasos()
        {
            var response = new BaseResponse<IEnumerable<ColaAtencionSelectResponseDto>>();
            var casos = await _unitOfWork.ColaAtencion.ListaSelectColaAtencion();
            if (casos != null)
            {
                response.IsSuccess = true;  
                response.Data = _mapper.Map<IEnumerable<ColaAtencionSelectResponseDto>>(casos);
                response.Mensaje = MsgRespuesta.MESSAGE_QUERY;
            }
            else
            {
                response.IsSuccess = false;
                response.Mensaje = MsgRespuesta.MESSAGE_QUERY_EMPTY;
            }

            return response;
        }
        public async Task<BaseResponse<ColaAtencionResponseDto>> CasoById(decimal Id)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<bool>> RegistroCaso(ColaAtencionRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<bool>> EditarCaso(decimal Id, ColaAtencionRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<bool>> BorrarCaso(decimal Id)
        {
            throw new NotImplementedException();
        }










    }
}
