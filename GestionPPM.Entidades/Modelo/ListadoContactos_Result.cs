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
    
    public partial class ListadoContactos_Result
    {
        public int id_contacto { get; set; }
        public string nombre_contacto { get; set; }
        public string apellido_contacto { get; set; }
        public string cargo_contacto { get; set; }
        public string CodigoCatalogoCargoContacto { get; set; }
        public string mail_contacto { get; set; }
        public string telefono_contacto { get; set; }
        public string extension_contacto { get; set; }
        public string prefijo_pais { get; set; }
        public string celular_contacto { get; set; }
        public string TipoContacto { get; set; }
        public Nullable<int> CodigoCatalogoTipoContacto { get; set; }
        public string TextoCatalogoContacto { get; set; }
        public string Estado_Contacto { get; set; }
    }
}
