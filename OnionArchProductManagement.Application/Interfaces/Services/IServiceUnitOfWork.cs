using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.Interfaces.Services
{
    public interface IServiceUnitOfWork
    {
        public IProductService ProductService { get; }

        public ICategoryService CategoryService { get; }
    }
}
