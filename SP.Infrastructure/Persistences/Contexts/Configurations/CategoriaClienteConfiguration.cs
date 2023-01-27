using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Infrastructure.Persistences.Contexts.Configurations
{
    public class CategoriaClienteConfiguration : IEntityTypeConfiguration<CategoriaCliente>
    {
        public void Configure(EntityTypeBuilder<CategoriaCliente> builder)
        {
            builder.HasKey(e => e.CategoriaCliente1).HasName("pk_categoria_cliente");

            builder.ToTable("categoria_cliente", "schqpos");

            builder.Property(e => e.CategoriaCliente1)
                .HasMaxLength(20)
                .HasColumnName("categoria_cliente");
            builder.Property(e => e.Activo)
                .HasMaxLength(2)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("activo");
            builder.Property(e => e.Color)
                .HasMaxLength(15)
                .HasDefaultValueSql("'#FFFFFF'::character varying")
                .HasColumnName("color");
            builder.Property(e => e.CreadoPor)
                .HasMaxLength(50)
                .HasColumnName("creado_por");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(2000)
                .HasColumnName("descripcion");
            builder.Property(e => e.FechaCreacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_creacion");
            builder.Property(e => e.FechaModificacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_modificacion");
            builder.Property(e => e.MaxTiempo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("max_tiempo");
            builder.Property(e => e.MinTiempo)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("min_tiempo");
            builder.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .HasColumnName("modificado_por");
            builder.Property(e => e.PrioridadCola)
                .HasPrecision(5)
                .HasColumnName("prioridad_cola");
            builder.Property(e => e.TiempoDeseado).HasColumnName("tiempo_deseado");
        }
    }
}
