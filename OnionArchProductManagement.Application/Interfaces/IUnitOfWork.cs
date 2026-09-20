using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.Interfaces
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IProductRepository Products { get; }

        ICategoryRepository Categories { get; }
        Task<int> SaveAsync();
    }
}
