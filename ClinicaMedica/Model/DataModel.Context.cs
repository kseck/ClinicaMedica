﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataModelContainer : DbContext
    {
        public DataModelContainer()
            : base("name=DataModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Usuario> TB_Usuario { get; set; }
        public virtual DbSet<Paciente> TB_Usuario_Paciente { get; set; }
        public virtual DbSet<Localidade> TB_Localidade { get; set; }
        public virtual DbSet<Funcao> TB_Funcao { get; set; }
        public virtual DbSet<Consultorio> TB_Consultorio { get; set; }
        public virtual DbSet<QuadroFuncionarios> TB_QuadroFuncionarios { get; set; }
        public virtual DbSet<Especialidade> TB_Especialidade { get; set; }
        public virtual DbSet<Exame> TB_Exame { get; set; }
        public virtual DbSet<Consulta> TB_Consulta { get; set; }
        public virtual DbSet<AgendaExame> TB_AgendaExame { get; set; }
        public virtual DbSet<ConsultorioExame> TB_ConsultorioExame { get; set; }
        public virtual DbSet<MedicoEspecialidade> TB_MedicoEspecialidade { get; set; }
    }
}
