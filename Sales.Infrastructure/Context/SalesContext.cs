using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sales.Domain.Entities;

namespace Sales.Infrastructure.Context
{
    public class SalesContext
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public List<Payment> Payments { get; set; } = new List<Payment>();

        public SalesContext()
        {
            
            SeedData();
        }

        private void SeedData()
        {
            var category1 = new Category { Id = 1, Name = "Laptops" };
            var category2 = new Category { Id = 2, Name = "Smartphones" };

            Categories.Add(category1);
            Categories.Add(category2);

            Products.Add(new Product { Id = 1, Name = "MacBook Pro", Price = 2500, Stock = 10, Category = category1 });
            Products.Add(new Product { Id = 2, Name = "iPhone 14", Price = 1200, Stock = 20, Category = category2 });
        }
    }
}

