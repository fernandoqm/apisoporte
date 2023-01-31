namespace SP.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaracion o matricula de nuestra interface a nivel de repositorios
        //A este nivel es la interfaz del crud
        IColaAtencionRepository ColaAtencion { get; }
        void SalvarCambios();
        Task SalvarCambiosAsync();

    }
}
