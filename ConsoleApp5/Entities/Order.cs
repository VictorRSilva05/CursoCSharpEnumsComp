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

        public Order(DateTime moment, OrderStatus status)
        {
            this.moment = moment;
            this.status = status;
        }

        public override string ToString()
        {
            return "Order moment: "
                + moment
                + "\n"
                + "Order status: "
                + status;
        }
    }
}
