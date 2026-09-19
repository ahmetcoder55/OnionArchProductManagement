using Microsoft.EntityFrameworkCore;
using OnionArchProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Persistence.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Product> Products { get; set; }


    }
}
