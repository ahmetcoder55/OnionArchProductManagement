using OnionArchProductManagement.Application.DTOs;
using OnionArchProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.Interfaces
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<Product>> GetCategoryWithDetailAsync();
    }
}
