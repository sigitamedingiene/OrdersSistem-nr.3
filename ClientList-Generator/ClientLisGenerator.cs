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
            return $"FirstName: {Name}";
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
            return $"LastName: {Name}";
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
            return $"Adress: {Adress} str. House No.{house} Apartment No.{apartment}";
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
            return $"Email: {Email}@mail.com";
        }

        public void clientListGenerator()
        {
            List<string> clientList = new List<string>();
            for (int i = 0; i < 50; i++)
            {
                clientList.Add(GenerateRandomName(6));
                clientList.Add(GenerateRandomLastName(7));
                clientList.Add(GenerateRandomAdress(5));
                clientList.Add(GenerateRandomEmail(8));
                clientList.Add("---------------------");
            }


            var filename = "clients.txt";
            var path = @$"C:\Users\Vartotojas\source\repos\Lesson-15\OrdersSistem(nr.4)\{filename}";
            File.WriteAllLines(path, clientList);

            var jsonFilename = "clients.json";
            string jsonString = JsonSerializer.Serialize(clientList);
            var jsonPath = @$"C:\Users\Vartotojas\source\repos\Lesson-15\OrdersSistem(nr.4)\{jsonFilename}";
            File.WriteAllText(jsonPath, jsonString);
            
        }
        
    }
}
