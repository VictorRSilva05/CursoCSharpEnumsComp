﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    internal class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
