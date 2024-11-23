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
    public class CategoryRepository : IRepository<Category>
    {
        private readonly SalesContext _context;

        public CategoryRepository(SalesContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await Task.FromResult(_context.Categories);
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await Task.FromResult(_context.Categories.FirstOrDefault(c => c.Id == id));
        }

        public async Task AddAsync(Category category)
        {
            _context.Categories.Add(category);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Category category)
        {
            var existing = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (existing != null)
            {
                existing.Name = category.Name;
            }
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }
            await Task.CompletedTask;
        }
    }
}

