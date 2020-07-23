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
    
    public partial class CodigoCotizacionInfo
    {
        public int id_codigo_cotizacion { get; set; }
        public string codigo_cotizacion { get; set; }
        public Nullable<System.DateTime> fecha_cotizacion { get; set; }
        public Nullable<int> CodigoCatalogoResponsable { get; set; }
        public string Responsable { get; set; }
        public Nullable<int> CodigoCatalogoEstatusCodigo { get; set; }
        public string EstatusCodigo { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string nombre_comercial_cliente { get; set; }
        public Nullable<int> CodigoCatalogoEjecutivo { get; set; }
        public string Ejecutivo { get; set; }
        public Nullable<int> CodigoCatalogoTipoRequerido { get; set; }
        public string TipoRequerido { get; set; }
        public Nullable<int> CodigoCatalogoTipoIntermediario { get; set; }
        public string TipoIntermediario { get; set; }
        public Nullable<int> CodigoCatalogoTipoProyecto { get; set; }
        public string TipoProyecto { get; set; }
        public Nullable<int> CodigoCatalogoDimensionProyecto { get; set; }
        public string DimensionProyecto { get; set; }
        public string AplicaContrato { get; set; }
        public string forma_pago { get; set; }
        public Nullable<decimal> forma_pago_1 { get; set; }
        public Nullable<decimal> forma_pago_2 { get; set; }
        public Nullable<decimal> forma_pago_3 { get; set; }
        public Nullable<decimal> forma_pago_4 { get; set; }
        public string EtapaCliente { get; set; }
        public Nullable<int> CodigoCatalogoEtapaCliente { get; set; }
        public string EtapaGeneral { get; set; }
        public Nullable<int> CodigoCatalogoEtapaGeneral { get; set; }
        public string EstatusDetallado { get; set; }
        public Nullable<int> CodigoCatalogoEstatusDetallado { get; set; }
        public string EstatusGeneral { get; set; }
        public Nullable<int> CodigoCatalogoEstatusGeneral { get; set; }
        public string TipoProductoPTOP { get; set; }
        public Nullable<int> CodigoCatalogoTipoProductoPTOP { get; set; }
        public string TipoPlan { get; set; }
        public Nullable<int> CodigoCatalogoTipoPlan { get; set; }
        public string TipoTarifa { get; set; }
        public Nullable<int> CodigoCatalogoTipoTarifa { get; set; }
        public string TipoMigracion { get; set; }
        public Nullable<int> CodigoCatalogoTipoMigracion { get; set; }
        public string TipoEtapaPTOP { get; set; }
        public Nullable<int> CodigoCatalogoTipoEtapaPTOP { get; set; }
        public string TipoSubsidio { get; set; }
        public Nullable<int> CodigoCatalogoTipoSubsidio { get; set; }
        public string Referido { get; set; }
        public Nullable<int> CodigoCatalogoReferido { get; set; }
        public string TipoZoho { get; set; }
        public Nullable<int> CodigoCatalogoTipoZoho { get; set; }
        public string TipoCliente { get; set; }
        public Nullable<int> CodigoCatalogoTipoCliente { get; set; }
        public string nombre_proyecto { get; set; }
        public string descripcion_proyecto { get; set; }
        public string TipoFEE { get; set; }
        public Nullable<int> CodigoCatalogoTipoFEE { get; set; }
        public string CreacionSAFI { get; set; }
        public string Facturable { get; set; }
        public string area_departamento_usuario { get; set; }
        public string Pais { get; set; }
        public Nullable<int> CodigoCatalogoPais { get; set; }
        public string Ciudad { get; set; }
        public Nullable<int> CodigoCatalogoCiudad { get; set; }
        public string direccion { get; set; }
        public Nullable<int> id_empresa { get; set; }
        public string Empresa { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<bool> AplicaContratoCodigo { get; set; }
        public Nullable<int> Anio_FechaCotizacion { get; set; }
        public Nullable<int> Mes_FechaCotizacion { get; set; }
        public Nullable<int> Dia_FechaCotizacion { get; set; }
        public Nullable<int> CodigoCatalogoCreacionSAFI { get; set; }
        public decimal TotalSubLineaNegocio { get; set; }
        public string AreaDepartamento { get; set; }
        public string razon_social_cliente { get; set; }
        public Nullable<bool> usar_organigrama { get; set; }
        public string UsoOrganigrama { get; set; }
        public Nullable<int> IdSolicitud { get; set; }
    }
}
