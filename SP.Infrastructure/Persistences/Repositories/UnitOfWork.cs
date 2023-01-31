using SP.Infrastructure.Persistences.Contexts;
using SP.Infrastructure.Persistences.Interfaces;

namespace SP.Infrastructure.Persistences.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SoporteContext _context;

        public IColaAtencionRepository ColaAtencion {get; private set;}

        public UnitOfWork(SoporteContext context)
        {
            _context = context;
            ColaAtencion = new ColaAtencionRepository(_context);   
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        public void SalvarCambios()
        {
            _context.SaveChanges();
        }

        public async Task SalvarCambiosAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
