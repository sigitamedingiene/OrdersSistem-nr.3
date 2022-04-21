using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ClientList_Generator
{
    public class ClientLisGenerator
    {
        public string GenerateRandomName(int length)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v" };
            string[] vowels = { "a", "e", "i", "o", "u", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; 
            while (b < length)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            return Name;
        }
        public string GenerateRandomLastName(int length)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v" };
            string[] vowels = { "a", "e", "i", "o", "u", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2;
            while (b < length)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            return Name;
        }
        public string GenerateRandomAdress(int length)
        {
            Random rnd = new Random();
            int house = rnd.Next(1, 150);
            int apartment = rnd.Next(1, 150);

            Random adress = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v" };
            string[] vowels = { "a", "e", "i", "o", "u", "y", "os", "as" };
            string Adress = "";
            Adress += consonants[adress.Next(consonants.Length)].ToUpper();
            Adress += vowels[adress.Next(vowels.Length)];
            int b = 2; 
            while (b < length)
            {
                Adress += consonants[adress.Next(consonants.Length)];
                b++;
                Adress += vowels[adress.Next(vowels.Length)];
                b++;
            }
            return $"{Adress} str. House No.{house} Apartment No.{apartment}";
        }
        public string GenerateRandomEmail(int length)
        {
            Random email = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v", "a", "e", "i", "o", "u", "y", "os", "as" };
            string[] vowels = { "1", "2", "3", "4", "5", "6", "7", "8" };
            string Email = "";
            Email += consonants[email.Next(consonants.Length)];
            Email += vowels[email.Next(vowels.Length)];
            int b = 2; 
            while (b < length)
            {
                Email += consonants[email.Next(consonants.Length)];
                b++;
                Email += vowels[email.Next(vowels.Length)];
                b++;
            }
            return $"{Email}@mail.com";
        }


        public void clientListGenerator()
        {
            List<Client> clientList = new List<Client>();
            for (int i = 0; i < 500; i++)
            {
                Client client = new Client(GenerateRandomName(6), GenerateRandomLastName(7), GenerateRandomAdress(5), GenerateRandomEmail(8));
                clientList.Add(client);               
               
            }           

            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonFilename = "clients.json";
            string jsonString = JsonSerializer.Serialize(clientList, options);
            var jsonPath = @$"..\..\..\..\..\..\OrdersSistem(nr.4)\{jsonFilename}";
            File.WriteAllText(jsonPath, jsonString);

            var report = "client.txt";
            var path = @$"..\..\..\..\..\..\OrdersSistem(nr.4)\{report}";
            File.WriteAllText(path, jsonString);


        }
        
    }
}
