using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Certification")]
    public class Certification : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}