//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicaMedica.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuadroFuncionarios
    {
        public int IdConsultorio { get; set; }
        public int IdFuncionario { get; set; }
        public System.DateTime DataAdmissao { get; set; }
        public Nullable<System.DateTime> DataDemissao { get; set; }
        public bool Status { get; set; }
    
        public virtual Funcionario Funcionario { get; set; }
        public virtual Consultorio Consultorio { get; set; }
    }
}
