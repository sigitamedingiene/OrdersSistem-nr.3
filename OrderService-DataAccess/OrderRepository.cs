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
        private List<Order> order { get; set; }

        public OrderRepository()
        {
            ClientRepository clientRepo = new ClientRepository();
            List<Client> clients = clientRepo.Deserialaizer();         
            Client client1 = new Client(clients[0].FirstName, clients[0].LastName, clients[0].Adress, clients[0].Email);
            Client client2 = new Client(clients[1].FirstName, clients[1].LastName, clients[1].Adress, clients[1].Email);
            Client client3 = new Client(clients[3].FirstName, clients[3].LastName, clients[3].Adress, clients[3].Email);

            Service service1 = new Service("Nugaros masažas", "Atpalaiduojantis nugaros masažas, trukmė 35min.", 15.90m);
            Service service2 = new Service("Pėdų masažas", "Atpalaiduojantis pėdų masažas, trukmė 25min.", 10.90m);
            Service service3 = new Service("Viso kūno masažas", "Atpalaiduojantis viso kūno masažas, trukmė 60min.", 35.90m);

            var time1 = DateTime.Now;
            var time2 = DateTime.Now.AddDays(2);
            var time3 = DateTime.Now.AddHours(3);

            order = new List<Order>();
            order.Add(new Order(1, client1, service1, time1, 1));
            order.Add(new Order(2, client2, service2, time2, 1));
            order.Add(new Order(3, client3, service3, time3, 1));
        }

        public List<Order> Retrieve()
        {
            return order;
        }
    }
}
