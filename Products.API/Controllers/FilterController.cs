using Microsoft.AspNetCore.Mvc;
using Products.API.Models.DTOs;
using Products.API.Repositories.Filters;

namespace Products.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilterController : ControllerBase
    {
        private readonly IFilterRepository _filterRepository;

        public FilterController(IFilterRepository filterRepository)
        {
            _filterRepository = filterRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetFilters()
        {
            return Ok( new HttpResponseDto<FilterDto>(data:await this._filterRepository.GetFilters(),error:null));
        }
    }
}