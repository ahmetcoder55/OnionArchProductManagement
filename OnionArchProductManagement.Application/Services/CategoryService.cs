using AutoMapper;
using OnionArchProductManagement.Application.DTOs;
using OnionArchProductManagement.Application.Interfaces;
using OnionArchProductManagement.Application.Interfaces.Services;
using OnionArchProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace OnionArchProductManagement.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateOneCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            if(category is null)
            {
                throw new Exception();
            }
            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteOneCategoryAsync(CategoryDto categoryDto)
        {
            var category=_mapper.Map<Category>(categoryDto);
            _unitOfWork.Categories.Delete(category);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<CategoryDto>> GetAllCategoriesAsync()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync();
            var categoryDtos  = _mapper.Map<List<CategoryDto>>(categories);
            return categoryDtos;
        }

        public async Task<CategoryDto> GetByCategoryIdAsync(int id)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(id);
            return  _mapper.Map<CategoryDto>(category);
        }

        public async  Task UpdateOneCategoryAsync(CategoryDto categoryDto)
        {
            if (categoryDto == null)
            {
                throw new ArgumentNullException(nameof(categoryDto), "Güncellenecek kategori verisi boş olamaz.");
            }

            var existingCategory = await _unitOfWork.Categories.GetByIdAsync(categoryDto.Id);

            if (existingCategory == null)
            {
                throw new Exception($"Id'si {categoryDto.Id} olan kategori veritabanında bulunamadı.");
            }

           
            _mapper.Map(categoryDto, existingCategory);

             _unitOfWork.Categories.Update(existingCategory);
             await _unitOfWork.SaveAsync();
        


        }
    }
}
