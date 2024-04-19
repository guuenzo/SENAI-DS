using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_tarde.Domains
{
    [Table(nameof(Clinica))]
    [Index(nameof(CNPJ), IsUnique =true)]

    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="O nome da clinica é obrigatório!")]
        public string? Nome { get; set; }

        [Column(TypeName ="CHAR(14)")]
        [StringLength(14, MinimumLength =14, ErrorMessage ="CNPJ deve conter 14 dígitos")]
        [Required(ErrorMessage ="CNPJ obrigatório!")]
        public string? CNPJ { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Endereço obrigatório!")]
        public string? Endereco { get; set;}

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Razão social é obrigatória!")]
        public string? RazaoSocial { get; set;}

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="A hora de abertura é obrigatória!")]
        public string? HoraAbertura{ get; set;}

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="A hora de fechamento é obrigatória!")]
        public string? HoraFechamento { get; set;}
    }
}
