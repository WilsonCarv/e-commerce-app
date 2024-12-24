

using Products.API.Models.Entities;

namespace Products.API.Repositories.Products
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts(int page, int limit);
    }
}