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
    
    public partial class ListadoFacturarSAFI
    {
        public int Secuencial { get; set; }
        public string Cliente { get; set; }
        public string Identificacion { get; set; }
        public string Correos { get; set; }
        public string Direccion { get; set; }
        public string Detalle { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Iva { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProdcuto { get; set; }
        public string CentroCosto { get; set; }
        public string FormaPago { get; set; }
        public string CodigoBodega { get; set; }
    }
}
