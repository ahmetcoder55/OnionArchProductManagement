using OnionArchProductManagement.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnionArchProductManagement.Application.Interfaces
{
    public interface IGenericRepository<T> where T:class,IEntity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllByFilterAsync(Expression<Func<T,bool>> expression);
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
