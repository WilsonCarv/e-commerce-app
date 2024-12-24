
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.API.Models.Entities
{
    [Table("Product")]
    public class Product : BaseModel
    {
        public required Brand Brand { get; set; }
        public List<Allergen> Allergens { get; set; } = new List<Allergen>();
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
        public List<AnimalWelfare> AnimalWelfares { get; set; } = new List<AnimalWelfare>();
        public List<BusinessPractice> BusinessPractices { get; set; } = new List<BusinessPractice>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Certification> Certifications { get; set; } = new List<Certification>();
        public List<Climate> Climates { get; set; } = new List<Climate>();
        public List<ConsumerDiet> ConsumerDiets { get; set; } = new List<ConsumerDiet>();
        public List<Distributor> Distributors { get; set; } = new List<Distributor>();
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<Packaging> Packaging { get; set; } = new List<Packaging>();
        public List<Region> Regions { get; set; } = new List<Region>();
    }
}