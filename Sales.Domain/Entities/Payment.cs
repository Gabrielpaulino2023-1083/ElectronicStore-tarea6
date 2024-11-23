using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int OrderId { get; set; } 
        public Order Order { get; set; } 
        public decimal Amount { get; set; } 
        public DateTime PaymentDate { get; set; } 
    }
}
