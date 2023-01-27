using System;
using System.Collections.Generic;

namespace SP.Domain.Entities;

public partial class Evento
{
    public decimal Evento1 { get; set; }

    public decimal Ot { get; set; }

    public string? Recurso { get; set; }

    public string? Cliente { get; set; }

    public string? Equipo { get; set; }

    public string? Labor { get; set; }

    public string? Notas { get; set; }

    public string? Notas2 { get; set; }

    public double Cantidad { get; set; }

    public double CostoUnitario { get; set; }

    public double CostoTotal { get; set; }

    public DateTime? HoraInicio { get; set; }

    public DateTime? HoraFin { get; set; }

    public decimal? KilometrajeInicial { get; set; }

    public decimal? KilometrajeFinal { get; set; }

    public string CreadoPor { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public DateTime FechaModificacion { get; set; }

    public string Sucursal { get; set; } = null!;

    public string? ReportadoPor { get; set; }

    public string? ResuelveProblema { get; set; }

    public string? OmitirCostos { get; set; }

    public string TipoEvento { get; set; } = null!;

    public string TipoSoporte { get; set; } = null!;

    public string TipoLabor { get; set; } = null!;

    public decimal MontoKilometraje0 { get; set; }

    public decimal Gasolina0 { get; set; }

    public decimal Hospedaje0 { get; set; }

    public decimal Parqueo0 { get; set; }

    public decimal CantidadKilometros0 { get; set; }

    public decimal TotalTrasporte { get; set; }

    public decimal TotalAlimentacion { get; set; }

    public string? CategoriaCliente { get; set; }

    public string? CentroCosto { get; set; }

    public string? EsViatico { get; set; }

    /// <summary>
    /// R: Regular
    /// E: Extra
    /// D: Doble
    /// </summary>
    public string? Jornada { get; set; }
}
