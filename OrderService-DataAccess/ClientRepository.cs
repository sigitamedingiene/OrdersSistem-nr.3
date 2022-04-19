using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace OrderService_DataAccess
{
    public class ClientRepository
    {  
        public List<Client> Deserialaizer()
        {
            var path = @"C:\Users\Vartotojas\source\repos\Lesson-15\OrdersSistem(nr.4)\clients.json";
            var jsonString = File.ReadAllText(path);
            List<Client> clients = JsonSerializer.Deserialize<List<Client>>(jsonString);
            return clients;

            for (int i = 0; i < clients.Count; i++)
            {
                var report = @$"Vardas: {clients[i].FirstName};
Pavarde: {clients[i].LastName};
Gyvenamasis adresas: {clients[i].Adress};
Elektroninio pasto adresas: {clients[i].Email}";

                var fileName = "ClientReport.txt";
                var filePath = @$"C:\Users\Vartotojas\source\repos\Lesson-15\OrdersSistem(nr.4)\{fileName}";
                File.WriteAllText(filePath, report);

            }
        }

        public void ClientsRepository()
        {               
           
        }


    }
}
