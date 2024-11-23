using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; } 
        public User User { get; set; } 
        public DateTime OrderDate { get; set; } 
        public ICollection<OrderDetail> OrderDetails { get; set; } 
    }
}
