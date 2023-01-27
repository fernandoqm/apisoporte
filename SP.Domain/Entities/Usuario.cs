using System;
using System.Collections.Generic;

namespace SP.Domain.Entities;

public partial class Usuario
{
    public string CodUsuario { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido1 { get; set; } = null!;

    public string Apellido2 { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public string Identificacion { get; set; } = null!;

    public string? Email { get; set; }

    public string Superusuario { get; set; } = null!;

    public string CreadoPor { get; set; } = null!;

    public DateOnly FechaCreacion { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public DateOnly FechaModificacion { get; set; }

    public char? Activo { get; set; }

    public char UsuarioCrm { get; set; }

    public byte[]? Huella { get; set; }

    /// <summary>
    /// Almacena el valor para mostrar o no la ventana de notificaci�n al iniciar el Launcher
    /// </summary>
    public string MostrarVentanaNovedades { get; set; } = null!;
}
