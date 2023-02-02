using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SP.Domain.Entities;

namespace SP.Infrastructure.Persistences.Contexts.Configurations
{
    public class ColaAtencionConfiguration : IEntityTypeConfiguration<ColaAtencion>
    {
        public void Configure(EntityTypeBuilder<ColaAtencion> builder)
        {
           builder.HasKey(e => e.ColaAtencionId).HasName("pk_cola_atencion");

            builder.ToTable("cola_atencion", "schqpos");

            builder.HasIndex(e => e.Estado, "estado_index");

            builder.HasIndex(e => e.Evento, "idx_colaevento");

            builder.HasIndex(e => e.Tipo, "tipo_index");

            builder.Property(e => e.ColaAtencionId)
                .HasPrecision(20)
                .HasDefaultValueSql("nextval(('seq_cola_atencion'::text)::regclass)")
                .HasColumnName("cola_atencion");
            builder.Property(e => e.AnuladoPor)
                .HasMaxLength(50)
                .HasColumnName("anulado_por");
            builder.Property(e => e.CantidadLlamadas)
                .HasPrecision(10)
                .HasColumnName("cantidad_llamadas");
            builder.Property(e => e.CategoriaCliente)
                .HasMaxLength(20)
                .HasColumnName("categoria_cliente");
            builder.Property(e => e.CodCliente)
                .HasMaxLength(20)
                .HasColumnName("cod_cliente");
            builder.Property(e => e.CreadoPor)
                .HasMaxLength(50)
                .HasColumnName("creado_por");
            builder.Property(e => e.Emergencia)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("emergencia");
            builder.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'P'::character varying")
                .HasColumnName("estado");
            builder.Property(e => e.Evento)
                .HasPrecision(20)
                .HasColumnName("evento");
            builder.Property(e => e.FechaAnulacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_anulacion");
            builder.Property(e => e.FechaCreacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_creacion");
            builder.Property(e => e.FechaFinProceso)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_fin_proceso");
            builder.Property(e => e.FechaHoraReporte)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_hora_reporte");
            builder.Property(e => e.FechaInicioProceso)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_inicio_proceso");
            builder.Property(e => e.FechaModificacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_modificacion");
            builder.Property(e => e.FechaPendienteCliente)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_pendiente_cliente");
            builder.Property(e => e.FechaRellamda)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_rellamda");
            builder.Property(e => e.FechaRespuestaNcq)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_respuesta_ncq");
            builder.Property(e => e.FechaReversado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_reversado");
            builder.Property(e => e.FechaTiempoEspera)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_tiempo_espera");
            builder.Property(e => e.FinalizoPor)
                .HasMaxLength(50)
                .HasColumnName("finalizo_por");
            builder.Property(e => e.InicioPor)
                .HasMaxLength(50)
                .HasColumnName("inicio_por");
            builder.Property(e => e.LicenciaReporte)
                .HasMaxLength(20)
                .HasColumnName("licencia_reporte");
            builder.Property(e => e.ModificadoPor)
                .HasMaxLength(50)
                .HasColumnName("modificado_por");
            builder.Property(e => e.Notas)
                .HasMaxLength(5000)
                .HasColumnName("notas");
            builder.Property(e => e.PendienteClientePor)
                .HasMaxLength(50)
                .HasColumnName("pendiente_cliente_por");
            builder.Property(e => e.ProblemaReportado)
                .HasMaxLength(5000)
                .HasColumnName("problema_reportado");
            builder.Property(e => e.Rellamada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("rellamada");
            builder.Property(e => e.RellamdaPor)
                .HasMaxLength(50)
                .HasColumnName("rellamda_por");
            builder.Property(e => e.ReportadoPor)
                .HasMaxLength(50)
                .HasColumnName("reportado_por");
            builder.Property(e => e.Responsable)
                .HasMaxLength(50)
                .HasColumnName("responsable");
            builder.Property(e => e.ReversadoPor)
                .HasMaxLength(50)
                .HasColumnName("reversado_por");
            builder.Property(e => e.Semaforo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'V'::character varying")
                .HasColumnName("semaforo");
            builder.Property(e => e.TiempoAtencion)
                .HasPrecision(20)
                .HasDefaultValueSql("(0)::numeric")
                .HasColumnName("tiempo_atencion");
            builder.Property(e => e.TiempoEspera)
                .HasPrecision(20)
                .HasDefaultValueSql("(0)::numeric")
                .HasColumnName("tiempo_espera");
            builder.Property(e => e.TiemposModificadorPor)
                .HasMaxLength(50)
                .HasColumnName("tiempos_modificador_por");
            builder.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'L'::character varying")
                .HasColumnName("tipo");
            builder.Property(e => e.TipoContrato)
                .HasMaxLength(20)
                .HasColumnName("tipo_contrato");
            builder.Property(e => e.TrabajoRealizado)
                .HasMaxLength(5000)
                .HasColumnName("trabajo_realizado");
        }
    }
}
