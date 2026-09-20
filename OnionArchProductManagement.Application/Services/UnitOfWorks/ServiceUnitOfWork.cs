using AutoMapper;
using OnionArchProductManagement.Application.Interfaces;
using OnionArchProductManagement.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.Services.UnitOfWorks
{
    public class ServiceUnitOfWork : IServiceUnitOfWork
    {
        private readonly IProductService _productService;

        private readonly ICategoryService _categoryService;

        public ServiceUnitOfWork(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;
    }
}
