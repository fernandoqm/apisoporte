using SP.Infrastructure.Persistences.Contexts;
using SP.Infrastructure.Persistences.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Infrastructure.Persistences.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SoporteContext _context;
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(SoporteContext context)
        {
            _context = context;
            Category = new CategoryRepository();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SalvarCambios()
        {
            throw new NotImplementedException();
        }

        public Task SalvarCambiosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
