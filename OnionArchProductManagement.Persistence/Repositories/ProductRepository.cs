using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnionArchProductManagement.Application.DTOs;
using OnionArchProductManagement.Application.Interfaces;
using OnionArchProductManagement.Domain.Models;
using OnionArchProductManagement.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product, AppDbContext>, IProductRepository
    {
       
        public ProductRepository(AppDbContext context) : base(context)
        {
         
        }

        public async Task<List<Product>> GetCategoryWithDetailAsync()
        {
            var values= await _context.Products.Include(x => x.Category).ToListAsync();
            return values;
        }
    }
}
