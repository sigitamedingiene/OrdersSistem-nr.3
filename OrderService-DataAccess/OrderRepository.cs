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
            List<Client> clients = clientRepo.Retrieve();         
            Client client1 = new Client(clients[0].FirstName, clients[0].LastName, clients[0].Adress, clients[0].Email);
            Client client2 = new Client(clients[1].FirstName, clients[1].LastName, clients[1].Adress, clients[1].Email);
            Client client3 = new Client(clients[2].FirstName, clients[2].LastName, clients[2].Adress, clients[2].Email);
            Client client4 = new Client(clients[3].FirstName, clients[3].LastName, clients[3].Adress, clients[3].Email);
            Client client5 = new Client(clients[4].FirstName, clients[4].LastName, clients[4].Adress, clients[4].Email);

            Service service1 = new Service("Nugaros masažas", "Atpalaiduojantis nugaros masažas, trukmė 35min.", 15.90m);
            Service service2 = new Service("Pėdų masažas", "Atpalaiduojantis pėdų masažas, trukmė 25min.", 10.90m);
            Service service3 = new Service("Viso kūno masažas", "Atpalaiduojantis viso kūno masažas, trukmė 60min.", 35.90m);
            Service service4 = new Service("Kojų masažas", "Sportinis kojų masažas, trukmė 60min.", 25.90m);
            Service service5 = new Service("Pečių masažas", "Atpalaiduojantis pečių masažas, trukmė 30min.", 15.90m);

            var time1 = DateTime.Now;
            var time2 = DateTime.Now.AddHours(3);
            var time3 = DateTime.Now.AddDays(2);
            

            order = new List<Order>();
            order.Add(new Order(1, client1, service1, time1, 1, true));
            order.Add(new Order(2, client2, service2, time1, 1, false));
            order.Add(new Order(3, client3, service3, time1, 1, true));
            order.Add(new Order(4, client4, service1, time1, 2, true));
            order.Add(new Order(5, client5, service5, time1, 1, false));
            order.Add(new Order(6, client1, service3, time2, 1, false));
            order.Add(new Order(7, client2, service2, time2, 2, true));
            order.Add(new Order(8, client3, service3, time2, 1, true));
            order.Add(new Order(9, client4, service1, time2, 2, false));
            order.Add(new Order(10, client5, service5, time2, 1, false));
            order.Add(new Order(11, client1, service3, time3, 1, false));
            order.Add(new Order(12, client2, service2, time3, 2, false));
            order.Add(new Order(13, client3, service3, time3, 1, true));
            order.Add(new Order(14, client4, service1, time3, 2, false));
            order.Add(new Order(15, client5, service5, time3, 1, false));
        }

        public List<Order> Retrieve()
        {
            return order;
        }
    }
}
