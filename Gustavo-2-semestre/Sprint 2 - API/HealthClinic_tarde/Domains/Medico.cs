using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_tarde.Domains
{
    [Table(nameof(Medico))]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();

        [Column(TypeName ="CHAR(6)")]
        [Required(ErrorMessage ="CRM é obrigatória!")]
        [StringLength(6, MinimumLength =6, ErrorMessage ="CRM deve conter 6 dígitos(sigla CRM adcionada automaticamente)")]
        public string? CRM { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Expediente é obrigatório!")]
        public string? Expediente { get; set; }

        [Required(ErrorMessage ="Especialidade é obrigatória!")]
        public Guid IdEspecialidade { get; set; }

        [ForeignKey(nameof(IdEspecialidade))]
        public Especialidade? Especialidade { get; set; }
        
        [Required(ErrorMessage ="Usuario é obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
        
        [Required(ErrorMessage ="Clínica é obrigatória!")]
        public Guid IdClinica{ get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica? Clinica { get; set; }


    }
}
