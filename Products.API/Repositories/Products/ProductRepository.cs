
using Microsoft.EntityFrameworkCore;
using Products.API.Data;
using Products.API.Models.Entities;

namespace Products.API.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<List<Product>> GetProducts(int page = 1, int limit = 10)
        {
            page = page > 0 ? page : 1;
            limit = limit > 0 ? limit : 10;

            return await _context.Products.Include(p => p.Allergens).Include(p => p.AnimalWelfares)
            .Include(p => p.Attributes).Include(p => p.Brand).Include(p => p.BusinessPractices).Include(p => p.Categories).Include(p => p.Certifications).Include(p => p.Climates)
            .Include(p => p.ConsumerDiets).Include(p => p.Distributors).Include(p => p.Ingredients).Include(p => p.Packaging).Include(p => p.Regions)
            .Skip((page - 1) * limit).Take(limit).ToListAsync();
        }
    }
}