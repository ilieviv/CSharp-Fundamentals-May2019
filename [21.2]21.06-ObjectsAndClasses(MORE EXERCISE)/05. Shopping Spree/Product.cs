﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Shopping_Spree
{
    class Product
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
