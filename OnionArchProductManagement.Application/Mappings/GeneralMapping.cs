using AutoMapper;
using OnionArchProductManagement.Application.DTOs;
using OnionArchProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.Mappings
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
        }
    }
}
