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
    
    public partial class CabeceraDetalleCotizador_Result
    {
        public int id_cotizador { get; set; }
        public Nullable<int> id_codigo_cotizacion { get; set; }
        public Nullable<int> numero_dias { get; set; }
        public Nullable<System.DateTime> fecha_cotizacion { get; set; }
        public Nullable<System.DateTime> fecha_vencimiento { get; set; }
        public Nullable<decimal> version { get; set; }
        public string observacion { get; set; }
        public Nullable<decimal> subtotal { get; set; }
        public Nullable<decimal> porc_descuento { get; set; }
        public Nullable<decimal> valor_descuento { get; set; }
        public Nullable<decimal> porcentaje_iva { get; set; }
        public Nullable<decimal> valor_iva { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<bool> estado_cotizador { get; set; }
        public int id_detalle_cotizador { get; set; }
        public Nullable<int> id_cotizador1 { get; set; }
        public string entregable { get; set; }
        public Nullable<decimal> costo_total_entregable { get; set; }
        public Nullable<int> tipo_servicio { get; set; }
        public Nullable<int> cantidad_servicio { get; set; }
        public Nullable<decimal> valor_unitario_servicio { get; set; }
        public Nullable<decimal> costo_total_servicio { get; set; }
        public Nullable<int> tipo_gestion { get; set; }
        public Nullable<int> cantidad_gestion { get; set; }
        public Nullable<decimal> valor_unitario_gestion { get; set; }
        public Nullable<decimal> costo_total_gestion { get; set; }
    }
}
