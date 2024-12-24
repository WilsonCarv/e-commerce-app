using System.ComponentModel.DataAnnotations;

namespace Products.API.Models.Entities
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}