using Deserialaizer;
using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace OrderService_DataAccess
{
    public class ClientRepository
    {   
        private List<Client> clientsList { get; }
        public ClientRepository()
        {
            DataDeserialaizer deserialaizer = new DataDeserialaizer();
            clientsList = deserialaizer.DeserialaizeClientsList();

        }

        public List<Client> Retrieve()
        {               
           return clientsList;
        }


    }
}
