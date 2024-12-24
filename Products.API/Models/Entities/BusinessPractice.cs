
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("BusinessPractice")]
    public class BusinessPractice : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}