using AutoMapper;
using SP.Application.Commons.Base;
using SP.Application.Dtos.Request;
using SP.Application.Dtos.Response;
using SP.Application.Interfaces;
using SP.Application.Validators.ColaAtencion;
using SP.Domain.Entities;
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
            var response = new BaseResponse<ColaAtencionResponseDto>();
            var caso = await _unitOfWork.ColaAtencion.ColaAtencionById(Id); 

            if(caso != null)
            {
                response.IsSuccess = true;
                response.Data = _mapper.Map<ColaAtencionResponseDto>(caso);
                response.Mensaje = MsgRespuesta.MESSAGE_QUERY;
            }
            else
            {
                response.IsSuccess = false;
                response.Mensaje = MsgRespuesta.MESSAGE_QUERY_EMPTY;
            }

            return response;
        }
        public async Task<BaseResponse<bool>> RegistroCaso(ColaAtencionRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            var validaResultado = await _validationRules.ValidateAsync(requestDto);

            if(validaResultado.IsValid)
            {
                response.IsSuccess = false;
                response.Mensaje = MsgRespuesta.MESSAGE_VALIDADO;
                response.Errores = validaResultado.Errors;
                return response;
            }

            var caso = _mapper.Map<ColaAtencion>(requestDto);
            response.Data = await _unitOfWork.ColaAtencion.RegistrarCaso(caso);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Mensaje = MsgRespuesta.MESSAGE_SALVAR;
            }
            else
            {
                response.IsSuccess = false;
                response.Mensaje = MsgRespuesta.MESSAGE_FALLO;
            }

            return response;
        }
        public async Task<BaseResponse<bool>> EditarCaso(decimal Id, ColaAtencionRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            var casoEditar = await CasoById(Id);

            if(casoEditar.Data != null) 
            {
                response.IsSuccess = false;
                response.Mensaje = MsgRespuesta.MESSAGE_QUERY_EMPTY;
            }

            var caso = _mapper.Map<ColaAtencion>(requestDto);
            caso.ColaAtencionId= Id;
            response.Data = await _unitOfWork.ColaAtencion.EditarCaso(caso);

            if(response.Data)
            {
                response.IsSuccess = true;
                response.Mensaje = MsgRespuesta.MESSAGE_ACTUALIZAR;
            }
            else
            {
                response.IsSuccess = false;
                response.Mensaje = MsgRespuesta.MESSAGE_FALLO;
            }

            return response;
        }
        public async Task<BaseResponse<bool>> BorrarCaso(decimal Id)
        {
            var response = new BaseResponse<bool>();
            var caso = await CasoById(Id);

            if(caso.Data != null)
            {
                response.IsSuccess = false;
                response.Mensaje = MsgRespuesta.MESSAGE_QUERY_EMPTY;
            }

            response.Data = await _unitOfWork.ColaAtencion.BorrarCaso(Id);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Mensaje = MsgRespuesta.MESSAGE_BORRAR;
            }
            else
            {
                response.IsSuccess = false;
                response.Mensaje =MsgRespuesta.MESSAGE_FALLO;
            }

            return response;

        }










    }
}
