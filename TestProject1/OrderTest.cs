using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderService_DataAccess;
using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class OrderTest
    {
        public void OrderListIdNotMatch()
        {
            OrderRepository orders = new OrderRepository();
            List<Order> orderList = orders.Retrieve();
            for (int i = 0; i < orderList.Count; i++)
            {
                Assert.IsFalse(orderList[i].Id == orderList[i].Id);
            }
        }

        public void OrderListNotPaidClientListValid()
        {
            OrderRepository orders = new OrderRepository();
            List<Order> orderList = orders.Retrieve();
            

            bool expected = false;
            for (int i = 0; i < orderList.Count; i++)
            {
                if(orderList[i].IsPaid == expected)
                {
                    orders.GenerateClientsNotPaidList();
                    Assert.IsTrue(orderList[i].IsPaid  == expected);
                }
            }
            
        }
    }
}
