using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService_DataAccess
{
    public class ServiceRepository
    {
        private List<Service> service { get; }

        public ServiceRepository()
        {
            service = new List<Service>();
            service.Add(new Service("Nugaros masažas", "Atpalaiduojantis nugaros masažas, trukmė 35min.", 15.90m));
            service.Add(new Service("Pečių masažas", "Atpalaiduojantis pečių masažas, trukmė 35min.", 12.90m));
            service.Add(new Service("Viso kūno masažas", "Atpalaiduojantis viso kūno masažas, trukmė 60min.", 35.90m));
            service.Add(new Service("Pėdų masažas", "Atpalaiduojantis pėdų masažas, trukmė 25min.", 10.90m));
            service.Add(new Service("Galvos masažas", "Atpalaiduojantis galvos masažas, trukmė 45min.", 20.90m));

        }

        public List<Service> Retrieve()
        {
            return service;
        }

        public List<Service> RetrieveServicePrice(decimal price)
        {
            return service;
        }
    }
}
