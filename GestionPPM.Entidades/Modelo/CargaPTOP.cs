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
    
    public partial class CargaPTOP
    {
        public int id_carga_ptop { get; set; }
        public Nullable<int> id_comercio { get; set; }
        public Nullable<int> id_plan { get; set; }
        public Nullable<int> id_facturable_certificacion { get; set; }
        public Nullable<int> id_facturable_mensual { get; set; }
        public Nullable<int> mes { get; set; }
        public Nullable<int> anio { get; set; }
        public string detalle { get; set; }
        public Nullable<decimal> valor_certificacion { get; set; }
        public Nullable<int> trx_aprobadas { get; set; }
        public Nullable<int> trx_rechazadas { get; set; }
        public Nullable<decimal> monto_vendido_aprobado { get; set; }
        public Nullable<decimal> monto_vendido_rechazado { get; set; }
        public string observaciones { get; set; }
        public string correos { get; set; }
        public Nullable<System.DateTime> fecha_carga { get; set; }
        public Nullable<int> id_factura_PTOP { get; set; }
        public bool estado_transaccion { get; set; }
    }
}
