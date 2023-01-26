using System;
using System.Collections.Generic;

namespace SP.Domain.Entities;

public partial class Factura
{
    public decimal CodFactura { get; set; }

    public decimal CodControlCaja { get; set; }

    public DateTime FechaFactura { get; set; }

    public string? CodCliente { get; set; }

    public char Moneda { get; set; }

    public double TipoCambio { get; set; }

    public double MontoBrutoCol { get; set; }

    public double MontoBrutoDol { get; set; }

    public double MontoDescuentoCol { get; set; }

    public double MontoDescuentoDol { get; set; }

    public double MontoIvCol { get; set; }

    public double MontoIvDol { get; set; }

    public double MontoNetoCol { get; set; }

    public double MontoNetoDol { get; set; }

    public double PagadoCon { get; set; }

    public char Anulada { get; set; }

    public string CreadoPor { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public DateTime FechaModificacion { get; set; }

    public string TipoPago { get; set; } = null!;

    public double Cambio { get; set; }

    public string? NoDocumento { get; set; }

    public string? NoCuenta { get; set; }

    public string? CkEmisor { get; set; }

    public double? MontoCk { get; set; }

    public string? NombreCliente { get; set; }

    public double? MontoColMx { get; set; }

    public double? MontoDolMx { get; set; }

    public double? MontoCkMx { get; set; }

    public double? MontoCardMx { get; set; }

    public double? MontoExento { get; set; }

    public double? MontoGravado { get; set; }

    public double? SaldoDisponibleCliente { get; set; }

    public double? MontoRebajadoCliente { get; set; }

    public string? AplicadoInventario { get; set; }

    public DateTime? FechaAplicacion { get; set; }

    public decimal? NumDocumentoMovInv { get; set; }

    public string? AnulacionAplicadaInventario { get; set; }

    public string? NoVoucherMx { get; set; }

    public string? Notas { get; set; }

    public decimal? ProformaReferencia { get; set; }

    public string? RecursoProforma { get; set; }

    public string? FacturaExcenta { get; set; }

    public double? PorcImpServicio { get; set; }

    public double? TotalImpServicio { get; set; }

    public double? MontoTotalRedondeo { get; set; }

    public string? NombreBanco { get; set; }

    public string? CategoriaPrecios { get; set; }

    /// <summary>
    /// determina sobre que perido de pago se hizo la factura
    /// </summary>
    public string? PeriodoPago { get; set; }

    public string Bodega { get; set; } = null!;

    public decimal? NumeroApartado { get; set; }

    public string? Recurso { get; set; }

    public int? Liquidacion { get; set; }

    public string? TextoPromocion { get; set; }

    public decimal? Consolidado { get; set; }

    public string? EstadoConsolidado { get; set; }

    public decimal? Checkout { get; set; }

    public string? TransaccionPuntos { get; set; }

    public string? AnulacionPuntos { get; set; }

    public double? MontoPuntosMx { get; set; }

    public string? TransaccionRedencionPuntos { get; set; }

    public string ConceptoFacturacion { get; set; } = null!;

    public string? ClaveHacienda { get; set; }

    public string? ComisionCalculada { get; set; }

    public string? ComisionRecuperacionCalculada { get; set; }

    public string? ConsecutivoHacienda { get; set; }

    public string? EstadoHacienda { get; set; }

    public string? MensajeHacienda { get; set; }

    public string? Xml64 { get; set; }

    public string? Xmlrecibo64 { get; set; }

    public string? CorreoCliente { get; set; }

    public string? IdentificacionFe { get; set; }

    public string? EmailFe { get; set; }

    public string? TelefonoFe { get; set; }

    public string? TipoIdFe { get; set; }

    public string? SucursalFe { get; set; }

    public string? OrdenCompraCliente { get; set; }

    public string? XmlDolares { get; set; }

    public decimal? ControlFisico { get; set; }

    public string? CodBanco { get; set; }

    public string? AplicaDescuentoPago { get; set; }

    public string? PersonaRetiraMercaderia { get; set; }

    public string? CodigoActividadHacienda { get; set; }

    public double? IvaBonificaciones { get; set; }

    public string? TipoDocumentoReferencia { get; set; }

    public string? NumeroReferencia { get; set; }

    public DateTime? FechaEmisionReferencia { get; set; }

    public string? CodigoReferencia { get; set; }

    public string? RazonReferencia { get; set; }

    /// <summary>
    /// Campo para indicar si la factura está pendiente de entregar. Estados: Si(S). No(N)
    /// </summary>
    public string PendienteEntrega { get; set; } = null!;

    /// <summary>
    /// Estados: Bodega (B). Cliente (C). Cuentas por cobrar (CxC). Recurso (R)
    /// </summary>
    public string Custodia { get; set; } = null!;

    public decimal? EtiquetaIngresoEgreso { get; set; }

    public double MontoDescuentoExento { get; set; }

    public double MontoDescuentoGravado { get; set; }

    public decimal? EtiquetaPreventa { get; set; }

    public DateTime? FechaEtiqueta { get; set; }

    public double SaldoTributario { get; set; }

    public decimal? UbicacionDespacho { get; set; }

    public decimal? CantidadPedidoDevuelto { get; set; }

    public decimal? NotaCreditoReversion { get; set; }

    public string Despachada { get; set; } = null!;

    public string? DespachadaPor { get; set; }

    public DateTime? FechaDespachada { get; set; }

    public double TotalIvaDevuelto { get; set; }

    public decimal? CantidadLineas { get; set; }

    public double? MontoTransferenciaMx { get; set; }

    /// <summary>
    /// FK de la tabla cliente_detalle_gln, indica el gln correspondiente
    /// </summary>
    public int? Gln { get; set; }

    public string? GlnEntrega { get; set; }

    /// <summary>
    /// Almacena el dato del total de cajas livianas
    /// </summary>
    public decimal TotalCajasLivianas { get; set; }

    /// <summary>
    /// Almacena el dato del total de cajas pesadas
    /// </summary>
    public decimal TotalCajasPesadas { get; set; }

    /// <summary>
    /// almacena el �ltimo usuario que autoriz� una autorizaci�n manual de aplicaci�n de rea en el documento
    /// </summary>
    public string? UsuarioAutorizoRea { get; set; }

    /// <summary>
    /// indicador de si el documento fue generado con beneficio de rea
    /// </summary>
    public string? AplicaRea { get; set; }

    public double MontoIngresoAnticipado { get; set; }

    public virtual Cliente? CodClienteNavigation { get; set; }
}
