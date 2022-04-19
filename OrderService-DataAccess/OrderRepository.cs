using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService_DataAccess
{
    public class OrderRepository
    {
        private List<Order> order { get; }

        public OrderRepository()
        {   order = new List<Order>();

        }
    }
}
