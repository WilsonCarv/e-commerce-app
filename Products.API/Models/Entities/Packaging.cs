using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Packaging")]
    public class Packaging : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}