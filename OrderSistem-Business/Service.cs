using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSistem_Business
{
    public class Service
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }

        public Service (string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
