using OnionArchProductManagement.Application.Interfaces;
using OnionArchProductManagement.Domain.Models;
using OnionArchProductManagement.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category, AppDbContext>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
