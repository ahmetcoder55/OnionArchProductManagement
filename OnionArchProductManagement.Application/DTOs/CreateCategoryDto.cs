using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.DTOs
{
    public record CreateCategoryDto
    {
        public string CategoryName { get; init; }
    }
}
