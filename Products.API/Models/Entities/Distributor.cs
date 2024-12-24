
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Distributor")]
    public class Distributor : BaseModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}