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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Funcao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcao()
        {
            Funcionario = new HashSet<Funcionario>();
        }
    
        public int IdFuncao { get; set; }
        [Required(ErrorMessage = "O campo 'Nome da Fun��o' � obrigat�rio!", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public string Descricao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}
