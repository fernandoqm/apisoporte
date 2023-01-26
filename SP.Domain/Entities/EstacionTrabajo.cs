using System;
using System.Collections.Generic;

namespace SP.Domain.Entities;

public partial class EstacionTrabajo
{
    public string Lic { get; set; } = null!;

    public string Pro { get; set; } = null!;

    public string Hw { get; set; } = null!;

    public string? Tl { get; set; }

    public string? Fv { get; set; }

    public string? Ta { get; set; }

    public string? Uc { get; set; }

    public string? SystemTray { get; set; }

    public string? ModuloVentana { get; set; }

    public string? KeyCerrar { get; set; }

    public string FacturacionImprimeDirectoImpresora { get; set; } = null!;

    public string? FacturacionReporteImpresora { get; set; }

    public decimal FacturacionReporteCantCopias { get; set; }

    public string? EtiquetasImpresora { get; set; }

    public decimal EtiquetasCantCopias { get; set; }

    public string EtiquetasImpresionAutomatica { get; set; } = null!;

    public string? Sucursal { get; set; }

    public string? Descripcion { get; set; }

    public string? Caja { get; set; }

    public string? PuntoVenta { get; set; }

    public string? PuertoLectorSerial { get; set; }

    public string ActivarLectorSerial { get; set; } = null!;

    public string? TipoImpresion { get; set; }

    public string? TipoPuertoTiquete { get; set; }

    public string? PuertoTiquete { get; set; }

    public string? TipoPuertoComanda { get; set; }

    public string? PuertoComanda { get; set; }

    public string? ImpresoraTiquete { get; set; }

    public string? ImpresoraComanda { get; set; }

    public decimal? CantidadColumnas { get; set; }

    public decimal? VerColumnas { get; set; }

    public decimal? TiempoDelay { get; set; }

    public string? TipoImpresora { get; set; }

    public string? Playlist { get; set; }

    public decimal? TiempoImagenes { get; set; }

    public decimal CantLineasAvance { get; set; }

    public string? TipoAlgoritmo { get; set; }

    public string? UltimaBusquedaFamiliaCompras { get; set; }

    public string? UltimaBusquedaMarcaCompras { get; set; }

    public string? UltimaBusquedaArticuloCompras { get; set; }

    public string? UltimaBusquedaDescripcionArticuloCompras { get; set; }

    public string? DescCostoIgualDescVenta { get; set; }

    public string? ActualizaDescuentos { get; set; }

    public string? ActualizaPrecios { get; set; }

    public string? CategoriaPrecios { get; set; }

    public string? TabPrecioVenta { get; set; }

    public string? Redondeo { get; set; }

    public decimal? Tammanofuenteventas { get; set; }

    public decimal? Tammanofuentepreventas { get; set; }

    public decimal? Tammanofuenteproformas { get; set; }

    public string GenerarRespaldoLineas { get; set; } = null!;

    public string ProformaPreventaFacturacionImprimeDirectoImpresora { get; set; } = null!;

    public string? ProformaReporteImpresora { get; set; }

    public decimal ProformaReporteCantCopias { get; set; }

    public string? ChequesImpresora { get; set; }

    public decimal ChequesCantCopias { get; set; }

    public decimal? ToleranciaPositiva { get; set; }

    public decimal? ToleranciaNegativa { get; set; }

    public string? BodegaDefault { get; set; }

    public string ReciboImprimeDirectoImpresora { get; set; } = null!;

    public string? ReciboImpresora { get; set; }

    public decimal ReciboCantCopias { get; set; }

    public string? UltimaBusquedaDescripcionArticulo { get; set; }

    public string? TabCostoTotal { get; set; }

    public string? TabTransporte { get; set; }

    public int? DispositivoRetail { get; set; }

    public string? RutaImagenesArticulos { get; set; }

    public string UsarRutaImagenesArticulos { get; set; } = null!;

    public string ModoOpacoVentas { get; set; } = null!;

    public string NotaCreditoImprimeDirectoImpresora { get; set; } = null!;

    public string? TransaccionesBdActivas { get; set; }

    public string? UrlPrepago { get; set; }

    public string? ClientePrepago { get; set; }

    public string? ClavePrepago { get; set; }
}
