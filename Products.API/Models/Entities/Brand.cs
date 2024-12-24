
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Brand")]
    public class Brand : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}