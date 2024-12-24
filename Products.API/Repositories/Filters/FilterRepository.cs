

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Products.API.Data;
using Products.API.Models.DTOs;

namespace Products.API.Repositories.Filters
{
    public class FilterRepository : IFilterRepository
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        public FilterRepository(IMapper mapper, ApplicationDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<FilterDto> GetFilters()
        {
            var regions = this._mapper.Map<List<RegionDto>>(await this._context.Regions.ToListAsync());
            var categories = this._mapper.Map<List<CategoryDto>>(await this._context.Categories.ToListAsync());
            var brands = this._mapper.Map<List<BrandDto>>( await this._context.Brands.ToListAsync()); 
            var attributes = this._mapper.Map<List<AttributeDto>>( await this._context.Attributes.ToListAsync());
            var allergens = this._mapper.Map<List<AllergenDto>>(await this._context.Allergens.ToListAsync());
            var climates = this._mapper.Map<List<ClimateDto>>( await this._context.Climates.ToListAsync());
            var businessPractices = this._mapper.Map<List<BusinessPracticeDto>>( await this._context.BusinessPractices.ToListAsync());
            var consumerDiets = this._mapper.Map<List<ConsumerDietDto>>( await this._context.ConsumerDiets.ToListAsync());
            var ingredients = this._mapper.Map<List<IngredientDto>>(await this._context.Ingredients.ToListAsync());
            var packaging = this._mapper.Map<List<PackagingDto>>( await this._context.Packaging.ToListAsync());
            var distributors = this._mapper.Map<List<DistributorDto>>(await this._context.Distributors.ToListAsync());
            var certifications = this._mapper.Map<List<CertificationDto>>(await this._context.Certifications.ToListAsync());
            var animalWelfares = this._mapper.Map<List<AnimalWelfareDto>>(await this._context.AnimalWelfares.ToListAsync());

            return new FilterDto
            {
                regions = regions,
                categories = categories,
                brands = brands,
                attributes = attributes,
                allergens = allergens,
                climates = climates,
                businessPractices = businessPractices,
                consumerDiets = consumerDiets,
                ingredients = ingredients,
                packagings = packaging,
                distributors = distributors,
                certifications = certifications,
                animalWelfares = animalWelfares
            };
        }
    }
}