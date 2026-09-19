using Microsoft.EntityFrameworkCore;
using OnionArchProductManagement.Application.Interfaces;
using OnionArchProductManagement.Domain.Abstract;
using OnionArchProductManagement.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnionArchProductManagement.Persistence.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class,IEntity
        where TContext:DbContext
    {
        //Dependency Injection
        protected readonly AppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllByFilterAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
