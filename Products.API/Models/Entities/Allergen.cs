
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{

    [Table("Allergen")]
    public class Allergen : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}