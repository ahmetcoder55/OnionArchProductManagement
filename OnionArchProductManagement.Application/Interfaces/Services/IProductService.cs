using OnionArchProductManagement.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();

        Task<List<GetProductWithDetailDto>> GetProductWithDetailAsync();
        Task<ProductDto?> GetProductByIdAsync(int id);
        Task<ProductDto> CreateProductAsync(CreateProductDto createDto);
    }
}
