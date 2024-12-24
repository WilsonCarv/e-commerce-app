using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Region")]
    public class Region : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}