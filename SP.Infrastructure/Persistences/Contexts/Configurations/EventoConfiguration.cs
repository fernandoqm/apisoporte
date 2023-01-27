using Microsoft.EntityFrameworkCore;
using SP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Infrastructure.Persistences.Contexts.Configurations
{
    internal class EventoConfiguration : IEntityTypeConfiguration<Evento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(e => e.Evento1).HasName("pk_evento");

            builder.ToTable("evento", "schqpos");

            builder.HasIndex(e => new { e.Cliente, e.Sucursal }, "fki_evento_sucursal");

            builder.Property(e => e.Evento1)
                .HasPrecision(20)
                .HasDefaultValueSql("nextval(('evento_seq'::text)::regclass)")
                .HasColumnName("evento");
            builder.Property(e => e.Cantidad).HasColumnName("cantidad");
            builder.Property(e => e.CantidadKilometros0)
                .HasPrecision(10, 2)
                .HasColumnName("cantidad_kilometros0");
            builder.Property(e => e.CategoriaCliente)
                .HasMaxLength(20)
                .HasColumnName("categoria_cliente");
            builder.Property(e => e.CentroCosto)
                .HasMaxLength(20)
                .HasColumnName("centro_costo");
            builder.Property(e => e.Cliente)
                .HasMaxLength(20)
                .HasColumnName("cliente");
            builder.Property(e => e.CostoTotal).HasColumnName("costo_total");
            builder.Property(e => e.CostoUnitario).HasColumnName("costo_unitario");
            builder.Property(e => e.CreadoPor)
                .HasMaxLength(20)
                .HasColumnName("creado_por");
            builder.Property(e => e.Equipo)
                .HasMaxLength(20)
                .HasColumnName("equipo");
            builder.Property(e => e.EsViatico)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("es_viatico");
            builder.Property(e => e.FechaCreacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_creacion");
            builder.Property(e => e.FechaModificacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_modificacion");
            builder.Property(e => e.Gasolina0)
                .HasPrecision(20, 2)
                .HasColumnName("gasolina0");
            builder.Property(e => e.HoraFin)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("hora_fin");
            builder.Property(e => e.HoraInicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("hora_inicio");
            builder.Property(e => e.Hospedaje0)
                .HasPrecision(20, 2)
                .HasColumnName("hospedaje0");
            builder.Property(e => e.Jornada)
                .HasMaxLength(1)
                .HasComment("R: Regular\nE: Extra\nD: Doble")
                .HasColumnName("jornada");
            builder.Property(e => e.KilometrajeFinal)
                .HasPrecision(20)
                .HasColumnName("kilometraje_final");
            builder.Property(e => e.KilometrajeInicial)
                .HasPrecision(20)
                .HasColumnName("kilometraje_inicial");
            builder.Property(e => e.Labor)
                .HasMaxLength(20)
                .HasColumnName("labor");
            builder.Property(e => e.ModificadoPor)
                .HasMaxLength(20)
                .HasColumnName("modificado_por");
            builder.Property(e => e.MontoKilometraje0)
                .HasPrecision(20, 2)
                .HasColumnName("monto_kilometraje0");
            builder.Property(e => e.Notas)
                .HasMaxLength(3000)
                .HasColumnName("notas");
            builder.Property(e => e.Notas2)
                .HasMaxLength(3000)
                .HasColumnName("notas2");
            builder.Property(e => e.OmitirCostos)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("omitir_costos");
            builder.Property(e => e.Ot)
                .HasPrecision(20)
                .HasColumnName("ot");
            builder.Property(e => e.Parqueo0)
                .HasPrecision(20, 2)
                .HasColumnName("parqueo0");
            builder.Property(e => e.Recurso)
                .HasMaxLength(20)
                .HasColumnName("recurso");
            builder.Property(e => e.ReportadoPor)
                .HasMaxLength(200)
                .HasColumnName("reportado_por");
            builder.Property(e => e.ResuelveProblema)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("resuelve_problema");
            builder.Property(e => e.Sucursal)
                .HasMaxLength(20)
                .HasColumnName("sucursal");
            builder.Property(e => e.TipoEvento)
                .HasMaxLength(20)
                .HasColumnName("tipo_evento");
            builder.Property(e => e.TipoLabor)
                .HasMaxLength(20)
                .HasColumnName("tipo_labor");
            builder.Property(e => e.TipoSoporte)
                .HasMaxLength(1)
                .HasColumnName("tipo_soporte");
            builder.Property(e => e.TotalAlimentacion)
                .HasPrecision(30, 2)
                .HasColumnName("total_alimentacion");
            builder.Property(e => e.TotalTrasporte)
                .HasPrecision(30, 2)
                .HasColumnName("total_trasporte");
        }
    }
}
