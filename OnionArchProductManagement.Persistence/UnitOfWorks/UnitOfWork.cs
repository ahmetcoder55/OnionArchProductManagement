using OnionArchProductManagement.Application.Interfaces;
using OnionArchProductManagement.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly IProductRepository _productRepository;

        private readonly ICategoryRepository _categoryRepository;

        public UnitOfWork(AppDbContext context, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IProductRepository Products => _productRepository;

        public ICategoryRepository Categories => _categoryRepository;

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
