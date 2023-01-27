using System;
using System.Collections.Generic;

namespace SP.Domain.Entities;

public partial class TipoContrato
{
    public string TipoContrato1 { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Activo { get; set; } = null!;

    public decimal PrioridadCola { get; set; }

    public string CreadoPor { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public DateTime FechaModificacion { get; set; }
}
