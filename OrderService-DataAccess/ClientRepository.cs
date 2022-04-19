using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace OrderService_DataAccess
{
    public class ClientRepository
    {
        public List<Client> ClientsRepository()
        {
            var path = @"C:\Users\Vartotojas\source\repos\Lesson-15\OrdersSistem(nr.4)\clients.json";
            var jsonString = File.ReadAllText(path);
            List<Client> clients = JsonSerializer.Deserialize<List<Client>>(jsonString);

            return clients;
        }
    }
}
