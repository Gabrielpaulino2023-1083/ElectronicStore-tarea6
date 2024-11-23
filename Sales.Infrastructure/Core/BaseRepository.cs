using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sales.Domain.Repository;

namespace Sales.Infrastructure.Core
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        public virtual Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

