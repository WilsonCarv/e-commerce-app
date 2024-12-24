using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("ConsumerDiet")]
    public class ConsumerDiet : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}