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
    
    public partial class ConsultorioExame
    {
        public int IdConsultorio { get; set; }
        public int IdExame { get; set; }
    
        public virtual Consultorio Consultorio { get; set; }
        public virtual Exame Exame { get; set; }
    }
}