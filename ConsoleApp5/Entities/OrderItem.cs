using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    internal class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }

        public static double Subtotal(int qtd, double price)
        {
            return qtd * price;
        }
    }
}
