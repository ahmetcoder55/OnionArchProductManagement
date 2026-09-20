using OnionArchProductManagement.Application.DTOs;
using OnionArchProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllCategoriesAsync();


        Task<CategoryDto> GetByCategoryIdAsync(int id);

        Task CreateOneCategoryAsync(CreateCategoryDto createCategoryDto);

        Task DeleteOneCategoryAsync(CategoryDto categoryDto);

        Task UpdateOneCategoryAsync(CategoryDto categoryDto);
    }
}
