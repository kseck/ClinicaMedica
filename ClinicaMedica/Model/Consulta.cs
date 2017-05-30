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
    
    public partial class Consulta
    {
        public int IdConsulta { get; set; }
        public int IdentificacaoPaciente { get; set; }
        public int IdentificacaoMedico { get; set; }
        public int IdConsultorio { get; set; }
        public System.DateTime DataHoraInicio { get; set; }
        public System.DateTime DataHoraFim { get; set; }
        public bool Comparecimento { get; set; }
        public string Anotacoes { get; set; }
    
        public virtual Paciente Paciente { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual Consultorio Consultorio { get; set; }
    }
}