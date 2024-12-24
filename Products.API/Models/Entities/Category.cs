
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Category")]
    public class Category : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}