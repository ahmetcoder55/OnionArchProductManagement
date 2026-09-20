using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchProductManagement.Application.DTOs;
using OnionArchProductManagement.Application.Interfaces.Services;

namespace OnionArchProductManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IServiceUnitOfWork _serviceUnitOfWork;

        public ProductsController(IServiceUnitOfWork serviceUnitOfWork)
        {
            _serviceUnitOfWork = serviceUnitOfWork;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _serviceUnitOfWork.ProductService.GetAllProductsAsync();
            return Ok(products);
        }
        [HttpGet("get-details")]
        public async Task<IActionResult> GetAllWithDetail()
        {
            return Ok(
                await _serviceUnitOfWork.ProductService.GetProductWithDetailAsync()
                );
        }

        [HttpPost("create-product")]
        public async Task<IActionResult> Create([FromBody] CreateProductDto createDto)
        {
            var result = await _serviceUnitOfWork.ProductService.CreateProductAsync(createDto);
            return CreatedAtAction(nameof(GetAll), new { id = result.Id }, result);
        }
    }
}
