using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Sales.Domain.Entities;
using Sales.Domain.Repository;
using Sales.Infrastructure.Context;

namespace Sales.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SalesContext _context;

        public ProductRepository(SalesContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(_context.Products);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await Task.FromResult(_context.Products.FirstOrDefault(p => p.Id == id));
        }

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await Task.CompletedTask; 
        }

        public async Task UpdateAsync(Product product)
        {
            var existing = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
                existing.Stock = product.Stock;
                existing.CategoryId = product.CategoryId;
            }
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await Task.FromResult(_context.Products.Where(p => p.CategoryId == categoryId));
        }
    }
}

