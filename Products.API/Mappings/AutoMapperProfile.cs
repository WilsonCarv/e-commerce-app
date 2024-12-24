using AutoMapper;
using Products.API.Models.DTOs;
using Products.API.Models.Entities;

namespace Products.API.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BaseModel, BaseDto>().ReverseMap();

            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<BrandDto, Brand>().ReverseMap();
            CreateMap<Certification, CertificationDto>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<Climate, ClimateDto>().ReverseMap();
            CreateMap<Packaging, PackagingDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Models.Entities.Attribute, AttributeDto>().ReverseMap();
            CreateMap<Allergen, AllergenDto>().ReverseMap();
            CreateMap<Ingredient, IngredientDto>().ReverseMap();
            CreateMap<Distributor, DistributorDto>().ReverseMap();
            CreateMap<ConsumerDiet, ConsumerDietDto>().ReverseMap();
            CreateMap<AnimalWelfare, AnimalWelfareDto>().ReverseMap();
            CreateMap<BusinessPractice, BusinessPracticeDto>().ReverseMap();

        }
    }
}