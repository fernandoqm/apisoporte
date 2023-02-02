using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SP.Application.Dtos.Request;
using SP.Application.Interfaces;
using SP.Infrastructure.Commons.Base.Request;

namespace SP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasoController : ControllerBase
    {
        private readonly IColaAtencionApplication _colaAtencionApplication;

        public CasoController(IColaAtencionApplication colaAtencionApplication)
        {
            _colaAtencionApplication = colaAtencionApplication;
        }


        [HttpPost]
        public async Task<IActionResult> lstCasos([FromBody] BaseFiltersRequest filtros)
        {
            var response = await _colaAtencionApplication.lstCasos(filtros);
            return Ok(response);
        }

        [HttpGet("Select")]
        public async Task<IActionResult> lstSelectCaso()
        {
            var response = await _colaAtencionApplication.lstSelectCasos();
            return Ok(response);
        }

        [HttpGet("{casoId: decimal}")]
        public async Task<IActionResult> CasoById(decimal Id)
        {
            var response = await _colaAtencionApplication.CasoById(Id);
            return Ok(response);
        }

        [HttpPost("Registro")]
        public async Task<IActionResult> RegistroCaso([FromBody] ColaAtencionRequestDto requesDto)
        {
            var response = await _colaAtencionApplication.RegistroCaso(requesDto);
            return Ok(response);
        }

        [HttpPut("Editar/{casoId : decimal}")]
        public async Task<IActionResult> EditarCaso(decimal casoId, [FromBody] ColaAtencionRequestDto requesDto)
        {
            var response = await _colaAtencionApplication.EditarCaso(casoId,requesDto);
            return Ok(response);
        }

        [HttpPut("Borrar/{casoId : decimal}")]
        public async Task<IActionResult> BorrarCas(decimal casoId)
        {
            var response = await _colaAtencionApplication.BorrarCaso(casoId);
            return Ok(response);
        }

    }
}
