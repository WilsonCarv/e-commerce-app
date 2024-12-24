using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("AnimalWelfare")]
    public class AnimalWelfare : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}