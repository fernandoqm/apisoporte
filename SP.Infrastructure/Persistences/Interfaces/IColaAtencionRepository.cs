using SP.Domain.Entities;
using SP.Infrastructure.Commons.Base.Request;
using SP.Infrastructure.Commons.Base.Response;

namespace SP.Infrastructure.Persistences.Interfaces
{
    public interface IColaAtencionRepository
    {
        Task<BaseEntityResponse<ColaAtencion>> ListaColaAtencion(BaseFiltersRequest filters);
        Task<IEnumerable<ColaAtencion>> ListaSelectColaAtencion();
        Task<ColaAtencion> ColaAtencionById(decimal IdCaso);
        Task<bool> RegistrarCaso(ColaAtencion caso);
        Task<bool> EditarCaso(ColaAtencion caso);
        Task<bool> BorrarCaso(decimal IdCaso);
    }
}
