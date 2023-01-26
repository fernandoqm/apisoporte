using System;
using System.Collections.Generic;

namespace SP.Domain.Entities;

public partial class Llavero
{
    public decimal Llavero1 { get; set; }

    public string TipoLlavero { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public string? Notas { get; set; }

    public string? CreadoPor { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? ModificadoPor { get; set; }

    public DateTime? FechaModificacion { get; set; }
}
