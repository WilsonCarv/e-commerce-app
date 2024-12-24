using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Climate")]
    public class Climate : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}