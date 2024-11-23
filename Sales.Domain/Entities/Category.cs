using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } // Nombre de la categoría
        public ICollection<Product> Products { get; set; } // Relación uno a muchos
    }
}
