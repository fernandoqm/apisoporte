using Microsoft.EntityFrameworkCore;
using SP.Domain.Entities;
using System.Reflection;

namespace SP.Infrastructure.Persistences.Contexts
{
    public partial class SoporteContext : DbContext
    {
        public SoporteContext()
        {
        }

        public SoporteContext(DbContextOptions<SoporteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ColaAtencion> ColaAtencions { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<TipoContrato> TipoContratos { get; set; }
        public virtual DbSet<CategoriaCliente> CategoriaClientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}