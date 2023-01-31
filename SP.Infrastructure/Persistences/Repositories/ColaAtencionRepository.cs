using SP.Domain.Entities;
using SP.Infrastructure.Commons.Base.Request;
using SP.Infrastructure.Commons.Base.Response;
using SP.Infrastructure.Persistences.Contexts;
using SP.Infrastructure.Persistences.Interfaces;

namespace SP.Infrastructure.Persistences.Repositories
{
    public class ColaAtencionRepository : GenericRepository<ColaAtencion>, IColaAtencionRepository
    {
        private readonly SoporteContext _context;

        public ColaAtencionRepository(SoporteContext context)
        {
            _context = context;
        }

        public Task<BaseEntityResponse<ColaAtencion>> ListaColaAtencion(BaseFiltersRequest filters)
        {
            throw new NotImplementedException();
        }

        //Listado para los combos
        public Task<IEnumerable<ColaAtencion>> ListaSelectColaAtencion()
        {
            throw new NotImplementedException();
        }

        public Task<ColaAtencion> ColaAtencionById(decimal IdCaso)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegistrarCaso(ColaAtencion caso)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditarCaso(ColaAtencion caso)
        {
            throw new NotImplementedException();
        }

        public Task<bool> BorrarCaso(decimal IdCaso)
        {
            throw new NotImplementedException();
        }
    }
}
