using OnionArchProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnionArchProductManagement.Application.DTOs
{
    public record GetProductWithDetailDto
    {
    
        public int Id { get; init; }

        public int CategoryId { get; init; }
        public string Name { get; init; } = string.Empty;

        public string CategoryName { get; init; }
        public decimal Price { get; init; }
        public int Stock { get; init; }

      
    }
}
