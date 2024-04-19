using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_tarde.Domains
{
    [Table(nameof(Usuario))]
    [Index(nameof(Email), IsUnique =true)]

    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Nome do usuário é obrigatório!")]
        public string? Nome { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Email é obrigatório!")]
        public string? Email { get; set; }

        [Column(TypeName ="VARCHAR(60)")]
        [StringLength(60, MinimumLength =8, ErrorMessage ="Senha deve conter de 8 a 60 caracteres!")]
        [Required(ErrorMessage ="Senha é obrigatória")]
        public string? Senha { get; set; }

        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TipoUsuario? TipoUsuario { get; set; }
    }
}
