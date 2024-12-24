
namespace Products.API.Models.DTOs
{
    public class ProductDto: BaseDto
    {
        public required BrandDto Brand { get; set; }
        public List<AllergenDto> Allergens { get; set; } = new List<AllergenDto>();
        public List<AttributeDto> Attributes { get; set; } = new List<AttributeDto>();
        public List<AnimalWelfareDto> AnimalWelfares { get; set; } = new List<AnimalWelfareDto>();
        public List<BusinessPracticeDto> BusinessPractices { get; set; } = new List<BusinessPracticeDto>();
        public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public List<CertificationDto> Certifications { get; set; } = new List<CertificationDto>();
        public List<ClimateDto> Climates { get; set; } = new List<ClimateDto>();
        public List<ConsumerDietDto> ConsumerDiets { get; set; } = new List<ConsumerDietDto>();
        public List<DistributorDto> Distributors { get; set; } = new List<DistributorDto>();
        public List<IngredientDto> Ingredients { get; set; } = new List<IngredientDto>();
        public List<PackagingDto> Packaging { get; set; } = new List<PackagingDto>();
        public List<RegionDto> Regions { get; set; } = new List<RegionDto>();
    }
}