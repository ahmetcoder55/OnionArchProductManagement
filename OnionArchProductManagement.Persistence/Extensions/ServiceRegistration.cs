using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchProductManagement.Application.Interfaces;
using OnionArchProductManagement.Persistence.Context;
using OnionArchProductManagement.Persistence.Repositories;
using OnionArchProductManagement.Persistence.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Persistence.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            
        }
    }
}
