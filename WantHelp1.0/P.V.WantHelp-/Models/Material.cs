//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P.V.WantHelp_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        public int Id_Material { get; set; }
        public int Id_Usu { get; set; }
        public int Id_Curso { get; set; }
        public string archivos { get; set; }
        public string urlBase { get; set; }
        public string urlHost { get; set; }
    
        public virtual Cursos Cursos { get; set; }
        public virtual Cursos Cursos1 { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
