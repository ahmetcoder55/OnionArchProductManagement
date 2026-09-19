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

        public ServiceUnitOfWork(IProductService productService)
        {
            _productService = productService;
        }

        public IProductService ProductService => _productService;
    }
}
