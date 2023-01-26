using System;
using System.Collections.Generic;

namespace SP.Domain.Entities;

public partial class Cliente
{
    public string CodCliente { get; set; } = null!;

    public string? Cedula { get; set; }

    public string? Descripcion { get; set; }

    public string? DireccionEspecifica { get; set; }

    public string? Telefono1 { get; set; }

    public string? Telefono2 { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public double PorcDescuento { get; set; }

    public double MontoMaxCompra { get; set; }

    public char? TipoAplicacion { get; set; }

    public double SaldoDisponible { get; set; }

    public char? Activo { get; set; }

    public string CreadoPor { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string ModificadoPor { get; set; } = null!;

    public DateTime FechaModificacion { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido1 { get; set; }

    public string? Apellido2 { get; set; }

    public DateTime? FechaUltimaCompra { get; set; }

    public double? TopeCredito { get; set; }

    public string AceptaCredito { get; set; } = null!;

    public double? MontoDeudaCliente { get; set; }

    public DateTime? FechaUltimoMovimientoCxc { get; set; }

    /// <summary>
    /// Ya no se utiliza, se conserva por compatibilidad con otras versiones
    /// </summary>
    public decimal? PlazoDiasCredito { get; set; }

    public string? NumTarjeta { get; set; }

    public string? CategoriaPrecios { get; set; }

    public DateTime? FechaUltimoMovimientoAbono { get; set; }

    public string? PersonaAutorizada { get; set; }

    public string? Exento { get; set; }

    public string? RazonSocial { get; set; }

    public double? PorcentajeInteresMoratorio { get; set; }

    public double? PorcentajeDescuentoEstimulo { get; set; }

    public double? DiasDescuentoEstimulo { get; set; }

    public string PeriodoPago { get; set; } = null!;

    public string? Soporte { get; set; }

    public string? NotasSoporte { get; set; }

    public string? NotasLogmein { get; set; }

    public DateTime? FechaVenceSoporte { get; set; }

    public string? Contacto { get; set; }

    public string? TipoCliente { get; set; }

    public string? Zona { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string ClienteOcacional { get; set; } = null!;

    public double? Cuota { get; set; }

    public string? TipoSoporte { get; set; }

    public string RazonComercial { get; set; } = null!;

    public string TipoCedula { get; set; } = null!;

    public string UsarSiemprePrecioDefault { get; set; } = null!;

    public string? Provincia { get; set; }

    public string? Canton { get; set; }

    public string? Distrito { get; set; }

    public string? CentroCosto { get; set; }

    public string? NotaTi { get; set; }

    public string UtilizaSoftwareNcq { get; set; } = null!;

    public decimal? Distribuidor { get; set; }

    public string? Vendedor { get; set; }

    public string? PathArchivos { get; set; }

    public string? RecursoDefault { get; set; }

    public double IngresoAnticipadoMonto { get; set; }

    public string? ClientePadre { get; set; }

    public string CategoriaCliente { get; set; } = null!;

    public string TipoContrato { get; set; } = null!;

    public char? Implantacion { get; set; }

    public string? Latitud { get; set; }

    public string? Longitud { get; set; }

    public string? Clase { get; set; }

    public DateTime? FechaImplantacion { get; set; }

    public double DiasImplantacion { get; set; }

    public int? TotalLicencias { get; set; }

    public string? UsaQupos { get; set; }

    public string? TieneContratoLicencias { get; set; }

    public string? TieneUbitec { get; set; }

    public string? TienePagoServicios { get; set; }

    public string? ContratoSoporte { get; set; }

    public decimal? CantidadVisitasSoporte { get; set; }

    public decimal? PeriodicidadVisitasSoporteMes { get; set; }

    public DateTime? FechaUltimaOtPlaneadaSoporte { get; set; }

    public string? IdentificadorTributario { get; set; }

    public string? ActividadSucursal { get; set; }

    public string? RazonSocialIt { get; set; }

    public string? SucursalIt { get; set; }

    public string? DescripcionSucursalIt { get; set; }

    public string? VersionActual { get; set; }

    public string? RecursoResponsableCobro { get; set; }

    public string? AplicaRedondeosSistema { get; set; }

    public decimal CantidadMinimaCategoriaPrecios { get; set; }

    public string TipoDescuentoValidar { get; set; } = null!;

    public string? NotasCliente { get; set; }

    public string? NombreRepresentanteLegal1 { get; set; }

    public string? CedulaRepresentanteLegal1 { get; set; }

    public string? DireccionRepresentanteLegal1 { get; set; }

    public string? TelefonosRepresentanteLegal1 { get; set; }

    public string? EstadoCivilRepresentanteLegal1 { get; set; }

    public string? OcupacionRepresentanteLegal1 { get; set; }

    public string? NotasRepresentanteLegal1 { get; set; }

    public string? NombreRepresentanteLegal2 { get; set; }

    public string? CedulaRepresentanteLegal2 { get; set; }

    public string? DireccionRepresentanteLegal2 { get; set; }

    public string? TelefonosRepresentanteLegal2 { get; set; }

    public string? EstadoCivilRepresentanteLegal2 { get; set; }

    public string? OcupacionRepresentanteLegal2 { get; set; }

    public string? NotasRepresentanteLegal2 { get; set; }

    public string TipoCredito { get; set; } = null!;

    public string? PuntualidadPago { get; set; }

    public string? NumeroAcuerdoCredito { get; set; }

    public string? NotasCredito { get; set; }

    public DateTime? FechaAprobacionCredito { get; set; }

    public string UsarMoratorioConcepto { get; set; } = null!;

    public string? Script { get; set; }

    public string? OrigenUbicacion { get; set; }

    public DateTime? FechaUltimaCompraContado { get; set; }

    public DateTime? FechaUltimaCompraCredito { get; set; }

    public decimal? CantidadCuotasCxc { get; set; }

    public int FrecuenciaRuta { get; set; }

    public string? Dias { get; set; }

    public string CuentaCerrada { get; set; } = null!;

    public string XmlDolares { get; set; } = null!;

    public decimal PorcentajeDescuentoPago { get; set; }

    public decimal DiasDescuentoPago { get; set; }

    public decimal DiasGraciaInteres { get; set; }

    public string? EmailGeneral { get; set; }

    public string VentasExentasDerechoCreditoFiscal { get; set; } = null!;

    public string? TipoDocumentoExo { get; set; }

    public string? NumeroDocumentoExo { get; set; }

    public string? NombreInstitucionExo { get; set; }

    public DateOnly? FechaEmisionExo { get; set; }

    /// <summary>
    /// Campo utilizado para validar los topes de crédito en facturación
    /// </summary>
    public string VueltaGira { get; set; } = null!;

    /// <summary>
    /// Es la cantidad de dias de gracia para facturar un crédito vencido
    /// </summary>
    public decimal DiasGraciaFacturarCreditoVencido { get; set; }

    /// <summary>
    /// Es para indicar si a la hora de incluir facturas de reparto en la liquidación se deben hacer trámites de cobro
    /// </summary>
    public string TramiteCobro { get; set; } = null!;

    /// <summary>
    /// Se utiliza para advertir al vendedor si está seleccionando mal la etiqueta del cliente
    /// </summary>
    public decimal? PreventaEtiqueta { get; set; }

    /// <summary>
    /// tipo de cobro que se le cobrará al cliente
    /// </summary>
    public decimal? TipoDeCobro { get; set; }

    public DateOnly? FechaInicioExo { get; set; }

    public DateOnly? FechaFinExo { get; set; }

    public string? CodigoImpuestoTarifaReducida { get; set; }

    /// <summary>
    /// Indica si al cliente le pueden facturar con el método de pago Crédito (contado)
    /// </summary>
    public string FacturarCreditoContado { get; set; } = null!;

    /// <summary>
    /// Indica el comportamiento para el cliente cuando tiene crédito vencido al facturar.
    /// P = PERMITE
    /// B = BLOQUEA
    /// S = SOLICITA AUTORIZACIÓN
    /// </summary>
    public string FacturarCreditoVencido { get; set; } = null!;

    /// <summary>
    /// Indica la cantidad de días en los que el cliente debio haber hecho un abono para poder hacer preventas/proformas de CRCO si cuenta con facturas vencidas.
    /// </summary>
    public decimal DiasFacturaVencidaSinAbono { get; set; }

    public string? LiquidacionDiasCobro { get; set; }

    /// <summary>
    /// Indica si el cliente genera tiquete:
    ///  S = Siempre
    ///  N = Nunca
    ///  O = Opcional (de vez en cuando)
    /// </summary>
    public string GeneraTiquete { get; set; } = null!;

    public string? ClienteApiToken { get; set; }

    /// <summary>
    /// Indica el tamaño del cliente. MI = Micro PE = Pequeño ME = Mediano GR = Grande
    /// </summary>
    public string? TamanoCliente { get; set; }

    public string UsarCodigoFabrica { get; set; } = null!;

    /// <summary>
    /// Indica si para el cliente es obligado definir un GLN en Preventa, Facturación, NC y ND
    /// </summary>
    public string RequeridoDefinirGln { get; set; } = null!;

    /// <summary>
    /// Indica si para el cliente es obligatorio definir la orden de compra en Preventa y Facturación
    /// </summary>
    public string RequeridoDefinirOrdenCompra { get; set; } = null!;

    /// <summary>
    /// Determina si a la hora de hacer una nota de crédito el sistema obliga a definir datos del cliente (número de nota y monto de nota), solo aplica para notas de crédito manuales
    /// </summary>
    public string RequeridoDatosClienteNotaCredito { get; set; } = null!;

    public string? Implantador { get; set; }

    /// <summary>
    /// Define si es aplicable para rea
    /// </summary>
    public string AplicaRea { get; set; } = null!;

    /// <summary>
    /// Define la fecha de vencimiento para los que aplican a rea
    /// </summary>
    public DateTime? FechaVencimientoRea { get; set; }

    /// <summary>
    /// Define si para el cliente se debe de actualizar los datos de REA consultanto a Hacienda cada vez que va a facturar, esto es porque hay clientes que son la excepci�n y se deben de marcar como que aplican REA pero son R�gimen tradicional, de manera que se les debe de aplicar la tarifa de REA aunque ante hacienda NO se encuentren en ese r�gimen.
    ///  S=Se omite la validaci�n con Hacienda, solo vale lo que diga el mantenimiento del cliente
    ///  N= Siempre se valida el estado de REA con Hacienda al momento de seleccionarlo en facturaci�n, preventa y proforma
    /// </summary>
    public string OmitirActualizarDatosReaFacturacion { get; set; } = null!;

    public virtual Cliente? ClientePadreNavigation { get; set; }

    public virtual ICollection<Evento> Eventos { get; } = new List<Evento>();

    public virtual ICollection<Factura> Facturas { get; } = new List<Factura>();

    public virtual ICollection<Cliente> InverseClientePadreNavigation { get; } = new List<Cliente>();
}
