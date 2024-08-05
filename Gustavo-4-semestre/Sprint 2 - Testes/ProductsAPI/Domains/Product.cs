using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProductsAPI.Domains
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public Guid IdProduct {  get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(40)")]
        //[Required(ErrorMessage = "O nome é obrigatório!")]
        public string? Name { get; set; }

        [Column(TypeName = "DECIMAL(10, 2)")]
        //[Required(ErrorMessage = "O preço é obrigatório!")]
        public decimal? Price { get; set; }
    }
}
