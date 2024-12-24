

using Products.API.Models.DTOs;

namespace Products.API.Repositories.Filters
{
    public interface IFilterRepository
    {
        Task<FilterDto> GetFilters();
    }
}