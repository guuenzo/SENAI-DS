using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_tarde.Domains
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="O telefone é obrigatório!")]
        public string? Telefone { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Endereço é obrigatório!")]
        public string? Endereco { get; set;}

        [Column(TypeName ="CHAR(9)")]
        [StringLength(9, MinimumLength =9, ErrorMessage ="RG deve conter 9 dígitos!")]
        [Required(ErrorMessage ="RG é obrigatório!")]
        public string? RG { get; set;}

        [Column(TypeName ="CHAR(11)")]
        [StringLength(11, MinimumLength =11, ErrorMessage ="CPF deve conter 11 dígitos")]
        [Required(ErrorMessage ="CPF é obrigatório!")]
        public string? CPF { get; set; }

        [Required(ErrorMessage ="O usuário é obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
