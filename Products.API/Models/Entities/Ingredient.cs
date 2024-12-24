
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Ingredient")]
    public class Ingredient : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}