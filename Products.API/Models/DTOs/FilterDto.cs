
namespace Products.API.Models.DTOs
{
    public class FilterDto
    {
        public List<AttributeDto>? attributes { get; set; }
        public List<AllergenDto>? allergens { get; set; }
        public List<AnimalWelfareDto>? animalWelfares { get; set; }
        public List<BusinessPracticeDto>? businessPractices { get; set; }
        public List<CategoryDto>? categories { get; set; }
        public List<CertificationDto>? certifications { get; set; }
        public List<ClimateDto>? climates { get; set; }
        public List<ConsumerDietDto>? consumerDiets { get; set; }
        public List<DistributorDto>? distributors { get; set; }
        public List<IngredientDto>? ingredients { get; set; }
        public List<PackagingDto>? packagings { get; set; }
        public List<RegionDto>? regions { get; set; }
        public List<BrandDto>? brands { get; set; }
    }
}