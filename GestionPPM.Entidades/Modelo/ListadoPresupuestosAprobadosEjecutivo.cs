//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionPPM.Entidades.Modelo
{
    using System;
    
    public partial class ListadoPresupuestosAprobadosEjecutivo
    {
        public int id_facturacion_safi { get; set; }
        public Nullable<int> id_codigo_cotizacion { get; set; }
        public string codigo_cotizacion { get; set; }
        public string TipoIntermediario { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string nombre_comercial_cliente { get; set; }
        public string direccion { get; set; }
        public string Ciudad { get; set; }
        public string Ejecutivo { get; set; }
        public Nullable<int> EjecutivoID { get; set; }
        public string TelefonoEjecutivo { get; set; }
        public string nombre_proyecto { get; set; }
        public Nullable<int> UltimaIDCotizacion { get; set; }
        public Nullable<decimal> UltimaVersionCotizacion { get; set; }
        public Nullable<decimal> TotalCotizacion { get; set; }
        public string ObservacionCotizacion { get; set; }
        public string detalle_cotizacion { get; set; }
        public Nullable<int> numero_pago { get; set; }
        public Nullable<int> id_codigo_producto { get; set; }
        public string nombre_producto { get; set; }
        public string codigo_producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal subtotal_pago { get; set; }
        public decimal iva_pago { get; set; }
        public decimal descuento_pago { get; set; }
        public decimal total_pago { get; set; }
        public Nullable<System.DateTime> fecha_prefactura { get; set; }
        public string numero_prefactura { get; set; }
        public Nullable<System.DateTime> fecha_factura { get; set; }
        public string numero_factura { get; set; }
        public Nullable<System.DateTime> fecha_nota_credito { get; set; }
        public string numero_nota_credito { get; set; }
        public string numero_retencion { get; set; }
        public Nullable<bool> aprobacion_prefactura_ejecutivo { get; set; }
        public Nullable<bool> aprobacion_final { get; set; }
        public Nullable<System.DateTime> fecha_aprobacion_prefactura_ejecutivo { get; set; }
        public Nullable<bool> prefactura_consolidada { get; set; }
        public Nullable<System.DateTime> fecha_aprobacion_final { get; set; }
        public string NombresCompletosUsuarioAprobacionInicial { get; set; }
        public string NombresCompletosUsuarioAprobacionFinal { get; set; }
        public string AprobacionPrefacturaEjecutivo { get; set; }
        public string AprobacionFinal { get; set; }
        public string PrefacturaConsolidada { get; set; }
        public string TipoDocumento { get; set; }
        public Nullable<bool> UtilizadoEnActa { get; set; }
        public Nullable<bool> UtilizadoEnActaCliente { get; set; }
        public Nullable<bool> UtilizadoEnActaContabilidad { get; set; }
        public Nullable<bool> estado { get; set; }
        public string EstadoDocumento { get; set; }
        public int Anulada { get; set; }
        public string MKT { get; set; }
    }
}
