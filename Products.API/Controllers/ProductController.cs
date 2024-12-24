using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Products.API.Models.DTOs;
using Products.API.Repositories.Products;

namespace Products.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductController(IMapper mapper, IProductRepository productRepository)
        {
            this._mapper = mapper;
            this._productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(int page, int limit)
        {
            var products = await _productRepository.GetProducts(page,limit);
            return Ok(new HttpResponseDto<List<ProductDto>>(data:_mapper.Map<List<ProductDto>>(products), error: null));
        }
    }
}