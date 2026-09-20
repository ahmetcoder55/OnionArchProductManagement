using OnionArchProductManagement.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnionArchProductManagement.Domain.Models
{
    public class Category:IEntity
    {
        [Key]
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public ICollection<Product>? Products { get; set; } = new List<Product>();
    }
}
