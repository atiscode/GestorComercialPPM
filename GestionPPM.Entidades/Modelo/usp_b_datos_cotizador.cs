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
    
    public partial class usp_b_datos_cotizador
    {
        public string fechaCotizacion { get; set; }
        public string fechaVencimiento { get; set; }
        public string EjecutivoComercial { get; set; }
        public string TiempoInicioActividades { get; set; }
        public string Cliente { get; set; }
        public string Contacto { get; set; }
        public string NombreProyecto { get; set; }
        public string TipoProyecto { get; set; }
        public string DimensionProyecto { get; set; }
        public string Observaciones { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> ValorDescuento { get; set; }
        public string Iva { get; set; }
        public Nullable<decimal> ValorIva { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string mail { get; set; }
    }
}
