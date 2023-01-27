using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaracion o matricula de nuestra interface a nivel de repositorios
        ICategoryRepository Category { get; }
        void SalvarCambios();
        Task SalvarCambiosAsync();

    }
}
