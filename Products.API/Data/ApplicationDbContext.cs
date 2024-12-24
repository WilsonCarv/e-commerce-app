using Microsoft.EntityFrameworkCore;
using Products.API.Models.Entities;

namespace Products.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public required DbSet<Product> Products { get; set; }
        public required DbSet<Brand> Brands { get; set; }
        public required DbSet<Category> Categories { get; set; }
        public required DbSet<Allergen> Allergens { get; set; }
        public required DbSet<AnimalWelfare> AnimalWelfares { get; set; }
        public required DbSet<Models.Entities.Attribute> Attributes { get; set; }
        public required DbSet<BusinessPractice> BusinessPractices { get; set; }
        public required DbSet<Certification> Certifications { get; set; }
        public required DbSet<Climate> Climates { get; set; }
        public required DbSet<ConsumerDiet> ConsumerDiets { get; set; }
        public required DbSet<Distributor> Distributors { get; set; }
        public required DbSet<Ingredient> Ingredients { get; set; }
        public required DbSet<Packaging> Packaging { get; set; }
        public required DbSet<Region> Regions { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}