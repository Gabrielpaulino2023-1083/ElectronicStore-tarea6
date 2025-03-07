﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } 
        public decimal Price { get; set; } 
        public int Stock { get; set; } 
        public int CategoryId { get; set; } 
        public Category Category { get; set; } 
    }
}
