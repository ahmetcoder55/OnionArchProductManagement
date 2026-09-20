using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchProductManagement.Application.DTOs;
using OnionArchProductManagement.Application.Interfaces.Services;

namespace OnionArchProductManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IServiceUnitOfWork _service;

        public CategoriesController(IServiceUnitOfWork service)
        {
            _service = service;
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            return Ok(
                await _service.CategoryService.GetAllCategoriesAsync()
                );
        }
        [HttpPost("create-one")]
        public async Task<IActionResult> CreateOneProductAsync([FromBody] CreateCategoryDto createCategoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _service.CategoryService.CreateOneCategoryAsync(createCategoryDto);
            return Created();
        }
    }
}
