using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.DTOs
{
    public record CreateProductDto(string Name, decimal Price, int Stock);
}
