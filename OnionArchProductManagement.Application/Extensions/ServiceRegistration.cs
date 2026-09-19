using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OnionArchProductManagement.Application.Interfaces.Services;
using OnionArchProductManagement.Application.Services;
using OnionArchProductManagement.Application.Services.UnitOfWorks;
using OnionArchProductManagement.Application.Validators;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OnionArchProductManagement.Application.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // AutoMapper
            services.AddAutoMapper(x=>x.AddMaps(assembly));

           services.AddValidatorsFromAssemblyContaining<CreateProductDtoValidator>();


            // Servisler ve Service Unit of Work
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IServiceUnitOfWork, ServiceUnitOfWork>();
        }
    }
}
