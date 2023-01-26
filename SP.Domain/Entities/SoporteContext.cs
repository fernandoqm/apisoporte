using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SP.Domain.Entities;

public partial class SoporteContext : DbContext
{
    public SoporteContext()
    {
    }

    public SoporteContext(DbContextOptions<SoporteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Llavero> Llaveros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=soporte;Username=usrqpos;Password=12345");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Llavero>(entity =>
        {
            entity.HasKey(e => e.Llavero1).HasName("pk_llavero");

            entity.ToTable("llavero", "schqpos");

            entity.Property(e => e.Llavero1)
                .HasPrecision(20)
                .HasDefaultValueSql("nextval(('seq_llavero'::text)::regclass)")
                .HasColumnName("llavero");
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .HasColumnName("clave");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(20)
                .HasColumnName("cod_cliente");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(20)
                .HasColumnName("creado_por");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_modificacion");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(20)
                .HasColumnName("modificado_por");
            entity.Property(e => e.Notas)
                .HasMaxLength(300)
                .HasColumnName("notas");
            entity.Property(e => e.TipoLlavero)
                .HasMaxLength(20)
                .HasColumnName("tipo_llavero");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .HasColumnName("usuario");
        });
        modelBuilder.HasSequence("bitacora_checkout_seq", "schqpos");
        modelBuilder.HasSequence("bitacora_checkout_seq_compras", "schqpos");
        modelBuilder.HasSequence("bitacora_envio_nube_seq", "schqpos");
        modelBuilder.HasSequence("bitacora_token_factura_seq", "schqpos").HasMax(9909908899087789L);
        modelBuilder.HasSequence("bitacoraerrorescxc_seq", "schqpos");
        modelBuilder.HasSequence("c_seq_archivo_transferencia", "schqpos");
        modelBuilder.HasSequence("c_seq_beneficiario_tercero", "schqpos");
        modelBuilder.HasSequence("c_seq_tercero", "schqpos");
        modelBuilder.HasSequence("c_seq_tercero_contacto", "schqpos");
        modelBuilder.HasSequence("c_seq_tipo_articulo", "schqpos");
        modelBuilder.HasSequence("checkout_compras_seq", "schqpos");
        modelBuilder.HasSequence("checkout_seq", "schqpos");
        modelBuilder.HasSequence("comanda_seq", "schqpos");
        modelBuilder.HasSequence("concepto_liquidacion_pago_seq", "schqpos").StartsAt(8L);
        modelBuilder.HasSequence("control_caja_seq", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("cuenta_banco_seq", "schqpos");
        modelBuilder.HasSequence("cxp_seq", "schqpos");
        modelBuilder.HasSequence("documento_pago_rh_documento_pago_seq", "schqpos");
        modelBuilder.HasSequence("documentos_pago_seq", "schqpos");
        modelBuilder.HasSequence("evento_seq", "schqpos");
        modelBuilder.HasSequence("historial_precio_seq", "schqpos");
        modelBuilder.HasSequence("ingreso_anticipado_doc_seq", "schqpos");
        modelBuilder.HasSequence("ingreso_anticipado_seq", "schqpos");
        modelBuilder.HasSequence("justificacion_saldos_mixta_seq", "schqpos");
        modelBuilder.HasSequence("linea_detalle_factura_cargada_excel_seq", "schqpos").HasMax(999999999999999999L);
        modelBuilder.HasSequence("liquidacion_documento_mensajeria_seq", "schqpos");
        modelBuilder.HasSequence("liquidacion_documento_pago_seq", "schqpos");
        modelBuilder.HasSequence("liquidacion_liquidacion_seq", "schqpos");
        modelBuilder.HasSequence("meta_ventas_meta_ventas_seq", "schqpos");
        modelBuilder.HasSequence("mov_num_documento_seq", "schqpos");
        modelBuilder.HasSequence("movimiento_cxc_seq", "schqpos");
        modelBuilder.HasSequence("movimiento_cxp_aplicado_seq", "schqpos");
        modelBuilder.HasSequence("movimiento_cxp_seq", "schqpos");
        modelBuilder.HasSequence("notas_predifinidas_seq", "schqpos").HasMax(9909908899087789L);
        modelBuilder.HasSequence("num_abono_apartado", "schqpos");
        modelBuilder.HasSequence("num_apartado", "schqpos");
        modelBuilder.HasSequence("num_factura", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("num_factura_temporal", "schqpos");
        modelBuilder.HasSequence("num_proforma", "schqpos");
        modelBuilder.HasSequence("ofertas_seq", "schqpos");
        modelBuilder.HasSequence("ot_seq", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("pago_anticipado_doc_seq", "schqpos");
        modelBuilder.HasSequence("pago_anticipado_seq", "schqpos");
        modelBuilder.HasSequence("pago_proveedor_seq", "schqpos");
        modelBuilder.HasSequence("promociones_seq", "schqpos").StartsAt(100L);
        modelBuilder.HasSequence("qa_seq_ejecucion", "schqpos");
        modelBuilder.HasSequence("qa_seq_proyecto", "schqpos");
        modelBuilder.HasSequence("qa_seq_prueba", "schqpos");
        modelBuilder.HasSequence("qa_seq_tipo", "schqpos");
        modelBuilder.HasSequence("recepcion_id_seq", "schqpos");
        modelBuilder.HasSequence("sec_accion_personal_excel", "schqpos").HasMax(999999L);
        modelBuilder.HasSequence("sec_control_puntos_por_articulo", "schqpos");
        modelBuilder.HasSequence("sec_control_puntos_por_factura", "schqpos");
        modelBuilder.HasSequence("sec_proyeccion_venta", "schqpos");
        modelBuilder.HasSequence("sec_proyeccion_venta_clientes_excluidos", "schqpos");
        modelBuilder.HasSequence("sec_proyeccion_venta_detalle", "schqpos");
        modelBuilder.HasSequence("seq_abono_multiple_ingreso_anticipado", "schqpos");
        modelBuilder.HasSequence("seq_abonos", "schqpos");
        modelBuilder.HasSequence("seq_accion_pedido_devuelto", "schqpos");
        modelBuilder.HasSequence("seq_activo_bitacora", "schqpos");
        modelBuilder.HasSequence("seq_activo_estado", "schqpos");
        modelBuilder.HasSequence("seq_activo_sub_ubicacion", "schqpos");
        modelBuilder.HasSequence("seq_activo_ubicacion", "schqpos");
        modelBuilder.HasSequence("seq_aguinaldo", "schqpos");
        modelBuilder.HasSequence("seq_alquiler_articulo", "schqpos");
        modelBuilder.HasSequence("seq_articulo_foto", "schqpos");
        modelBuilder.HasSequence("seq_articulo_historial_kilogramos", "schqpos");
        modelBuilder.HasSequence("seq_audi_periodos_trabajo", "schqpos");
        modelBuilder.HasSequence("seq_auditoria_inv_comprometido", "schqpos");
        modelBuilder.HasSequence("seq_auditorias_cambios_cliente", "schqpos");
        modelBuilder.HasSequence("seq_aux", "schqpos").StartsAt(394L);
        modelBuilder.HasSequence("seq_beneficiario_tercero", "schqpos");
        modelBuilder.HasSequence("seq_bitacora", "schqpos");
        modelBuilder.HasSequence("seq_bitacora_camb_cant", "schqpos");
        modelBuilder.HasSequence("seq_bitacora_qupos", "schqpos");
        modelBuilder.HasSequence("seq_bodega_seccion", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("seq_cambio_precio", "schqpos");
        modelBuilder.HasSequence("seq_categoria_documento", "schqpos").StartsAt(10L);
        modelBuilder.HasSequence("seq_cheque_transito", "schqpos");
        modelBuilder.HasSequence("seq_cierre_contable", "schqpos");
        modelBuilder.HasSequence("seq_cierre_datafono", "schqpos");
        modelBuilder.HasSequence("seq_cierre_tarjetas", "schqpos");
        modelBuilder.HasSequence("seq_citas", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("seq_clasificacion_articulo", "schqpos");
        modelBuilder.HasSequence("seq_clasificacion_cliente", "schqpos");
        modelBuilder.HasSequence("seq_cliente_autorizado", "schqpos");
        modelBuilder.HasSequence("seq_clientes", "schqpos");
        modelBuilder.HasSequence("seq_codigo_activo", "schqpos");
        modelBuilder.HasSequence("seq_codigo_articulo", "schqpos");
        modelBuilder.HasSequence("seq_codigo_empleado", "schqpos");
        modelBuilder.HasSequence("seq_codigo_familia", "schqpos");
        modelBuilder.HasSequence("seq_codigo_marca", "schqpos");
        modelBuilder.HasSequence("seq_codigo_proveedor", "schqpos");
        modelBuilder.HasSequence("seq_cola_atencion", "schqpos");
        modelBuilder.HasSequence("seq_comision_comision", "schqpos");
        modelBuilder.HasSequence("seq_compra_hh", "schqpos");
        modelBuilder.HasSequence("seq_conciliacion", "schqpos");
        modelBuilder.HasSequence("seq_consecutivo", "schqpos");
        modelBuilder.HasSequence("seq_consecutivo_auditoria_descuento", "schqpos");
        modelBuilder.HasSequence("seq_consolidado_mercaderia", "schqpos");
        modelBuilder.HasSequence("seq_contacto", "schqpos");
        modelBuilder.HasSequence("seq_control_caja_documento_pago", "schqpos");
        modelBuilder.HasSequence("seq_control_fisico_factura", "schqpos");
        modelBuilder.HasSequence("seq_controlcajahh_controlcajahh", "schqpos");
        modelBuilder.HasSequence("seq_cuenta_bancaria", "schqpos");
        modelBuilder.HasSequence("seq_depreciacion", "schqpos");
        modelBuilder.HasSequence("seq_detalles_errores_carga_excel_abonos", "schqpos");
        modelBuilder.HasSequence("seq_distribuidor", "schqpos");
        modelBuilder.HasSequence("seq_documento", "schqpos");
        modelBuilder.HasSequence("seq_documento_nube", "schqpos");
        modelBuilder.HasSequence("seq_empleado_bitacora", "schqpos");
        modelBuilder.HasSequence("seq_empleado_ubicacion_trabajo", "schqpos");
        modelBuilder.HasSequence("seq_entrega_parcial", "schqpos");
        modelBuilder.HasSequence("seq_etapa_produccion", "schqpos");
        modelBuilder.HasSequence("seq_etiqueta_ingresos_egresos", "schqpos");
        modelBuilder.HasSequence("seq_faltante_venta", "schqpos");
        modelBuilder.HasSequence("seq_gasto", "schqpos");
        modelBuilder.HasSequence("seq_historial_cambio_costo", "schqpos");
        modelBuilder.HasSequence("seq_historial_categorias", "schqpos");
        modelBuilder.HasSequence("seq_historial_certificado", "schqpos");
        modelBuilder.HasSequence("seq_historial_consecutivo_factura", "schqpos");
        modelBuilder.HasSequence("seq_historial_costo_promedio", "schqpos");
        modelBuilder.HasSequence("seq_historial_rango_bodega", "schqpos");
        modelBuilder.HasSequence("seq_imagen_coleccion", "schqpos");
        modelBuilder.HasSequence("seq_inicio_secion_dispositivos", "schqpos");
        modelBuilder.HasSequence("seq_insumo", "schqpos");
        modelBuilder.HasSequence("seq_justificacion_saldos_liquidacion", "schqpos");
        modelBuilder.HasSequence("seq_labor_diaria", "schqpos");
        modelBuilder.HasSequence("seq_labor_rh", "schqpos");
        modelBuilder.HasSequence("seq_linea_factura_nota_credito", "schqpos").StartsAt(2L);
        modelBuilder.HasSequence("seq_linea_factura_nota_debito", "schqpos");
        modelBuilder.HasSequence("seq_liquidacion_rh", "schqpos");
        modelBuilder.HasSequence("seq_llavero", "schqpos");
        modelBuilder.HasSequence("seq_lote_insumo", "schqpos");
        modelBuilder.HasSequence("seq_lote_insumo_movimiento", "schqpos");
        modelBuilder.HasSequence("seq_motivo_pedido_devuelto", "schqpos");
        modelBuilder.HasSequence("seq_motivo_retiro_activo", "schqpos").StartsAt(10L);
        modelBuilder.HasSequence("seq_movimiento_aux", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("seq_movimiento_banco", "schqpos");
        modelBuilder.HasSequence("seq_movimiento_inventario", "schqpos");
        modelBuilder.HasSequence("seq_movimiento_libro", "schqpos");
        modelBuilder.HasSequence("seq_nota_credito", "schqpos");
        modelBuilder.HasSequence("seq_nota_debito", "schqpos");
        modelBuilder.HasSequence("seq_notificacion", "schqpos");
        modelBuilder.HasSequence("seq_num_acc_personal", "schqpos");
        modelBuilder.HasSequence("seq_orden_compra", "schqpos");
        modelBuilder.HasSequence("seq_orden_produccion", "schqpos");
        modelBuilder.HasSequence("seq_ot_bitacora", "schqpos");
        modelBuilder.HasSequence("seq_pago_viatico", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("seq_pago_viatico_bol", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("seq_pagocomision_pagocomision", "schqpos");
        modelBuilder.HasSequence("seq_parametros_produccion", "schqpos");
        modelBuilder.HasSequence("seq_parentesco_familiar", "schqpos");
        modelBuilder.HasSequence("seq_perfil_imagen", "schqpos");
        modelBuilder.HasSequence("seq_preferencia", "schqpos");
        modelBuilder.HasSequence("seq_preventa_etiqueta", "schqpos");
        modelBuilder.HasSequence("seq_preventa_reimpresion", "schqpos");
        modelBuilder.HasSequence("seq_preventa_reimpresion_seccion", "schqpos");
        modelBuilder.HasSequence("seq_producto_terminado", "schqpos");
        modelBuilder.HasSequence("seq_producto_terminado_etapa", "schqpos");
        modelBuilder.HasSequence("seq_prorrata", "schqpos");
        modelBuilder.HasSequence("seq_proyeccion_compra", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("seq_recarga_prepago", "schqpos");
        modelBuilder.HasSequence("seq_region", "schqpos");
        modelBuilder.HasSequence("seq_reintegro_caja", "schqpos");
        modelBuilder.HasSequence("seq_release_notes", "schqpos");
        modelBuilder.HasSequence("seq_revaluacion_semoviente", "schqpos");
        modelBuilder.HasSequence("seq_saldo_inventario", "schqpos");
        modelBuilder.HasSequence("seq_solicitud_cambio", "schqpos");
        modelBuilder.HasSequence("seq_solicitud_cambio_archivo", "schqpos");
        modelBuilder.HasSequence("seq_solicitud_proyecto", "schqpos");
        modelBuilder.HasSequence("seq_solicitud_software", "schqpos");
        modelBuilder.HasSequence("seq_solicitudsoporte_solicitudsoporte", "schqpos");
        modelBuilder.HasSequence("seq_tarea_cliente", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("seq_tercero", "schqpos");
        modelBuilder.HasSequence("seq_tercero_contacto", "schqpos");
        modelBuilder.HasSequence("seq_tipo_activo", "schqpos");
        modelBuilder.HasSequence("seq_tipo_activo_sub_tipo", "schqpos");
        modelBuilder.HasSequence("seq_tipo_de_cobro", "schqpos");
        modelBuilder.HasSequence("seq_tipo_documento", "schqpos").StartsAt(20L);
        modelBuilder.HasSequence("seq_tipo_documento_archivo", "schqpos");
        modelBuilder.HasSequence("seq_tipo_documento_mensajeria", "schqpos");
        modelBuilder.HasSequence("seq_tipo_etiqueta_ingresos_egresos", "schqpos");
        modelBuilder.HasSequence("seq_tipo_gasto_detalle_contabilidad", "schqpos");
        modelBuilder.HasSequence("seq_tipo_precios", "schqpos").StartsAt(2L);
        modelBuilder.HasSequence("seq_toma_fisica", "schqpos");
        modelBuilder.HasSequence("seq_tramite_cobro", "schqpos");
        modelBuilder.HasSequence("seq_tramite_gasto", "schqpos");
        modelBuilder.HasSequence("seq_ubicacion_articulo", "schqpos").HasMin(0L);
        modelBuilder.HasSequence("seq_unificacion", "schqpos");
        modelBuilder.HasSequence("seq_version_sistema", "schqpos");
        modelBuilder.HasSequence("seq_version_sistema_rn", "schqpos");
        modelBuilder.HasSequence("seq_zona_ruta", "schqpos");
        modelBuilder.HasSequence("sucursal_seq", "schqpos");
        modelBuilder.HasSequence("tarjetas_historial_seq", "schqpos").HasMax(999999L);
        modelBuilder.HasSequence("tramite_pago_seq", "schqpos").HasMin(0L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
