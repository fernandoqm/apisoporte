using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SP.Domain.Entities;

namespace SP.Infrastructure.Persistences.Contexts.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.CodUsuario).HasName("pk_usuario");

            builder.ToTable("usuario", "schqpos");

            builder.Property(e => e.CodUsuario)
                .HasMaxLength(30)
                .HasColumnName("cod_usuario");
            builder.Property(e => e.Activo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("activo");
            builder.Property(e => e.Apellido1)
                .HasMaxLength(100)
                .HasColumnName("apellido1");
            builder.Property(e => e.Apellido2)
                .HasMaxLength(100)
                .HasColumnName("apellido2");
            builder.Property(e => e.Clave)
                .HasMaxLength(100)
                .HasDefaultValueSql("12345")
                .HasColumnName("clave");
            builder.Property(e => e.CreadoPor)
                .HasMaxLength(30)
                .HasColumnName("creado_por");
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            builder.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            builder.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");
            builder.Property(e => e.Huella).HasColumnName("huella");
            builder.Property(e => e.Identificacion)
                .HasMaxLength(50)
                .HasColumnName("identificacion");
            builder.Property(e => e.ModificadoPor)
                .HasMaxLength(30)
                .HasColumnName("modificado_por");
            builder.Property(e => e.MostrarVentanaNovedades)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasComment("Almacena el valor para mostrar o no la ventana de notificaci�n al iniciar el Launcher")
                .HasColumnName("mostrar_ventana_novedades");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            builder.Property(e => e.Superusuario)
                .HasMaxLength(1)
                .HasColumnName("superusuario");
            builder.Property(e => e.UsuarioCrm)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("usuario_crm");
        }
    }
}
