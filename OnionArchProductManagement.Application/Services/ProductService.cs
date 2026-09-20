using AutoMapper;
using OnionArchProductManagement.Application.DTOs;
using OnionArchProductManagement.Application.Interfaces;
using OnionArchProductManagement.Application.Interfaces.Services;
using OnionArchProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);
            if (product == null) return null;

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> CreateProductAsync(CreateProductDto createDto)
        {
            var existingProducts = await _unitOfWork.Products.GetAllAsync();
            if (existingProducts.Any(p => p.Name.Equals(createDto.Name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException($"'{createDto.Name}' adında bir ürün zaten var.");
            }

            var product = _mapper.Map<Product>(createDto);

            await _unitOfWork.Products.AddAsync(product);

            await _unitOfWork.SaveAsync();

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<List<GetProductWithDetailDto>> GetProductWithDetailAsync()
        {
            var products = await _unitOfWork.Products.GetCategoryWithDetailAsync();
            if(products is null)
            {
                throw new ArgumentException();
            }
            var productsDto=_mapper.Map<List<GetProductWithDetailDto>>(products);
            return productsDto;
        }
    }
}
