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
    public class TipoContratoConfiguration : IEntityTypeConfiguration<TipoContrato>
    {
        public void Configure(EntityTypeBuilder<TipoContrato> builder)
        {
            builder.HasKey(e => e.TipoContrato1).HasName("pk_tipo_contrato");

            builder.ToTable("tipo_contrato", "schqpos");

            builder.Property(e => e.TipoContrato1)
                .HasMaxLength(20)
                .HasColumnName("tipo_contrato");
            builder.Property(e => e.Activo)
                .HasMaxLength(2)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("activo");
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
            builder.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .HasColumnName("modificado_por");
            builder.Property(e => e.PrioridadCola)
                .HasPrecision(5)
                .HasColumnName("prioridad_cola");
        }
    }
}
