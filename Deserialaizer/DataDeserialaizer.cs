using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Deserialaizer
{
    public class DataDeserialaizer
    {
        public List<Client> DeserialaizeClientsList()
        {
            var path = @"..\..\..\..\..\..\clients.json";
            var jsonString = File.ReadAllText(path);
            List<Client> clientsList = JsonSerializer.Deserialize<List<Client>>(jsonString);
            return clientsList;
        }

    }
}
