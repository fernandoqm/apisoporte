using SP.Domain.Entities;
using SP.Infrastructure.Commons.Base.Request;
using SP.Infrastructure.Commons.Base.Response;
using SP.Infrastructure.Persistences.Contexts;
using SP.Infrastructure.Persistences.Interfaces;
using SP.Utilities.Static;
using System.Data.Entity;

namespace SP.Infrastructure.Persistences.Repositories
{
    public class ColaAtencionRepository : GenericRepository<ColaAtencion>, IColaAtencionRepository
    {
        private readonly SoporteContext _context;

        public ColaAtencionRepository(SoporteContext context)
        {
            _context = context;
        }

        public async Task<BaseEntityResponse<ColaAtencion>> ListaColaAtencion(BaseFiltersRequest filters)
        {
            var response = new BaseEntityResponse<ColaAtencion>();
            //se realiza la consulta con linq
            var colaAtencion = (from c in _context.ColaAtencions
                                select c).AsNoTracking().AsQueryable();

            //Se realiza la consulta según el número de filtro
            if (filters.NumFilter is not null && !string.IsNullOrEmpty(filters.TextFilter))
            {
                switch (filters.NumFilter)
                {
                    case 1:
                        colaAtencion = colaAtencion.Where(x => x.ProblemaReportado!.Contains(filters.TextFilter));
                        break;
                    case 2:
                        colaAtencion = colaAtencion.Where(x => x.CodCliente!.Contains(filters.TextFilter));
                        break;

                }
            }

            //Filtra el estado
            if (filters.StateFilter is not null)
            {
                colaAtencion = colaAtencion.Where(x => x.Estado.Equals(filters.StateFilter));
            }

            //Valida las fechas
            if(!string.IsNullOrEmpty(filters.StartDate) && !string.IsNullOrEmpty(filters.EndDate))
            {
                colaAtencion = colaAtencion.Where(x => x.FechaCreacion >= Convert.ToDateTime(filters.StartDate) &&
                                                       x.FechaCreacion <= Convert.ToDateTime(filters.EndDate).AddDays(1));
            }

            //Ordena por la columna Id
            if (filters.Sort is null) filters.Sort = "ColaAtencionId";

            response.TotalRecords = await colaAtencion.CountAsync();
            response.Items = await Ordering(filters, colaAtencion, !(bool)filters.DownLoad!).ToListAsync();
            return response;

        }

        //Listado para los combos
        public async Task<IEnumerable<ColaAtencion>> ListaSelectColaAtencion()
        {
            var colaAtencion = await _context.ColaAtencions
                .Where(x => x.Estado.Equals(TiposEstado.A)).AsNoTracking().ToListAsync();
            return colaAtencion;
        }

        public async Task<ColaAtencion> ColaAtencionById(decimal IdCaso)
        {
            var colaAtencion = await _context.ColaAtencions!.AsNoTracking().FirstOrDefaultAsync(x => x.ColaAtencionId.Equals(IdCaso));
            return colaAtencion!;
        }

        public async Task<bool> RegistrarCaso(ColaAtencion caso)
        {
            caso!.FechaCreacion = DateTime.Now;

            await _context.AddAsync(caso);

            var casosAfectados = await _context.SaveChangesAsync();
            return casosAfectados > 0;
        }

        public async Task<bool> EditarCaso(ColaAtencion caso)
        {
            caso!.FechaModificacion = DateTime.Now;

            _context.Update(caso);

            var casosAfectados = await _context.SaveChangesAsync();
            return casosAfectados > 0;
        }

        public async Task<bool> BorrarCaso(decimal IdCaso)
        {
            var colaAtencion = await _context.ColaAtencions.AsNoTracking().SingleOrDefaultAsync(x => x.ColaAtencionId.Equals(IdCaso));

            _context.Remove(colaAtencion);

            var casosAfectados = await _context.SaveChangesAsync();
            return casosAfectados > 0;

        }
    }
}
