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
    
    public partial class ListadoClientes_Result
    {
        public int id_cliente { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public string NombresApellidosUsuario { get; set; }
        public string Referido { get; set; }
        public Nullable<int> CodigoCatalogoReferido { get; set; }
        public string Intermediario { get; set; }
        public Nullable<int> CodigoCatalogoIntermediario { get; set; }
        public string TipoZoho { get; set; }
        public Nullable<int> CodigoCatalogoTipoZoho { get; set; }
        public string TipoCliente { get; set; }
        public Nullable<int> CodigoCatalogoTipoCliente { get; set; }
        public string TamanioEmpresa { get; set; }
        public Nullable<int> CodigoCatalogoTamanioEmpresa { get; set; }
        public string EtapaCliente { get; set; }
        public Nullable<int> CodigoCatalogoEtapaCliente { get; set; }
        public string EtapaGeneral { get; set; }
        public Nullable<int> CodigoCatalogoEtapaGeneral { get; set; }
        public string EstatusDetallado { get; set; }
        public Nullable<int> CodigoCatalogoEstatusDetallado { get; set; }
        public string EstatusGeneral { get; set; }
        public Nullable<int> CodigoCatalogoEstatusGeneral { get; set; }
        public string ruc_ci_cliente { get; set; }
        public string razon_social_cliente { get; set; }
        public string nombre_comercial_cliente { get; set; }
        public Nullable<decimal> ingresos_anuales_cliente { get; set; }
        public string Sector { get; set; }
        public Nullable<int> CodigoCatalogoSector { get; set; }
        public string Pais { get; set; }
        public Nullable<int> CodigoCatalogoPais { get; set; }
        public string Prefijo { get; set; }
        public string CiudadCliente { get; set; }
        public Nullable<int> CodigoCatalogoCiudadCliente { get; set; }
        public string direccion_cliente { get; set; }
        public string Estado_Cliente { get; set; }
    }
}
