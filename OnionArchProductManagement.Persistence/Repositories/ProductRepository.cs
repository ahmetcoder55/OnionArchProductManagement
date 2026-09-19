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
    }
}
