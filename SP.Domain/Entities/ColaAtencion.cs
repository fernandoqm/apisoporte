using System;
using System.Collections.Generic;

namespace SP.Domain.Entities;

public partial class ColaAtencion
{
    public decimal ColaAtencionId { get; set; }

    public string CodCliente { get; set; } = null!;

    public DateTime FechaHoraReporte { get; set; }

    public string? ProblemaReportado { get; set; }

    public string? TrabajoRealizado { get; set; }

    public decimal CantidadLlamadas { get; set; }

    public string? Responsable { get; set; }

    public char Estado { get; set; }

    public char Tipo { get; set; }

    public string? ReportadoPor { get; set; }

    public char Emergencia { get; set; }

    public decimal TiempoEspera { get; set; }

    public decimal TiempoAtencion { get; set; }

    public string? Notas { get; set; }

    public decimal? Evento { get; set; }

    public string Semaforo { get; set; } = null!;

    public string? InicioPor { get; set; }

    public DateTime? FechaInicioProceso { get; set; }

    public string? FinalizoPor { get; set; }

    public DateTime? FechaFinProceso { get; set; }

    public string CreadoPor { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public DateTime FechaModificacion { get; set; }

    public string? AnuladoPor { get; set; }

    public DateTime? FechaAnulacion { get; set; }

    public string? ReversadoPor { get; set; }

    public DateTime? FechaReversado { get; set; }

    public string? LicenciaReporte { get; set; }

    public string? PendienteClientePor { get; set; }

    public DateTime? FechaPendienteCliente { get; set; }

    public DateTime? FechaRespuestaNcq { get; set; }

    public string? TiemposModificadorPor { get; set; }

    public string? CategoriaCliente { get; set; }

    public string? TipoContrato { get; set; }

    public DateTime? FechaTiempoEspera { get; set; }

    public string Rellamada { get; set; } = null!;

    public string? RellamdaPor { get; set; }

    public DateTime? FechaRellamda { get; set; }
}
