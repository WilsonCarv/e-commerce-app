
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Attribute")]
    public class Attribute : BaseModel
    {
        public bool IsTopAttribute { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}