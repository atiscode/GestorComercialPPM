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
    
    public partial class ANSCliente
    {
        public int id_ans_sla { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string tipo_requerimiento { get; set; }
        public string descripción_sla { get; set; }
        public Nullable<int> tiempo_atencion_min { get; set; }
        public Nullable<bool> ans_estado { get; set; }
        public Nullable<int> id_tipo_solicitud { get; set; }
    }
}
