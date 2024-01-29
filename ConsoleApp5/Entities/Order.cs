using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Entities.Enums;

namespace ConsoleApp5.Entities
{
    internal class Order
    {
        public DateTime moment {  get; set; }
        public OrderStatus status { get; set; }
    }
}
