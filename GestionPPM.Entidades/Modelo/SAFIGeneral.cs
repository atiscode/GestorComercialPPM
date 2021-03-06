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
    using System.Collections.Generic;
    
    public partial class SAFIGeneral
    {
        public int id_facturacion_safi { get; set; }
        public Nullable<int> id_codigo_cotizacion { get; set; }
        public string detalle_cotizacion { get; set; }
        public string correos_facturacion { get; set; }
        public Nullable<int> numero_pago { get; set; }
        public Nullable<int> id_codigo_producto { get; set; }
        public Nullable<int> id_forma_pago { get; set; }
        public Nullable<int> id_centro_costos { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<decimal> precio_unitario { get; set; }
        public Nullable<decimal> subtotal_pago { get; set; }
        public Nullable<decimal> iva_pago { get; set; }
        public Nullable<decimal> descuento_pago { get; set; }
        public Nullable<decimal> total_pago { get; set; }
        public Nullable<System.DateTime> fecha_prefactura { get; set; }
        public string numero_prefactura { get; set; }
        public Nullable<System.DateTime> fecha_factura { get; set; }
        public string numero_factura { get; set; }
        public Nullable<System.DateTime> fecha_nota_credito { get; set; }
        public string numero_nota_credito { get; set; }
        public string numero_retencion { get; set; }
        public Nullable<bool> aprobacion_prefactura_ejecutivo { get; set; }
        public Nullable<int> aprobacion_prefactura_ejecutivo_UsuarioID { get; set; }
        public Nullable<System.DateTime> fecha_aprobacion_prefactura_ejecutivo { get; set; }
        public Nullable<bool> prefactura_consolidada { get; set; }
        public Nullable<bool> aprobacion_final { get; set; }
        public Nullable<System.DateTime> fecha_aprobacion_final { get; set; }
        public Nullable<int> aprobacion_final_UsuarioID { get; set; }
        public Nullable<bool> estado { get; set; }
        public string cuenta_contable { get; set; }
    }
}
