using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace OrderService_DataAccess
{
    public class ClientRepository
    {
        public class ClientVariables
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
            public string Email { get; set; }
        }

        private List<Client> client { get; set; }
        public void ClientsRepository()
        {
            string fileName = @"C:\Users\Vartotojas\source\repos\Lesson-15\OrdersSistem(nr.4)\clients.json";
            string jsonString = File.ReadAllText(fileName);
            ClientVariables clients = JsonSerializer.Deserialize<ClientVariables>(jsonString)!;

            client.Add(new Client(clients.FirstName, clients.LastName, clients.Adress, clients.Email));
            
                                  
        }
        public List<Client> Retrieve()
        {
            return client;
        }
    }
}
