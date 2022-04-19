using System;
using System.Collections.Generic;
using System.IO;

namespace ClientList_Generator
{
    public class ClientLisGenerator
    {
        public string GenerateRandomWord(int length)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v" };
            string[] vowels = { "a", "e", "i", "o", "u", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
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
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
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
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
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
            List<string> clientList = new List<string>();
            for (int i = 0; i < 50; i++)
            {
                clientList.Add(GenerateRandomWord(6));
                clientList.Add(GenerateRandomWord(7));
                clientList.Add(GenerateRandomAdress(5));
                clientList.Add(GenerateRandomEmail(8));
                clientList.Add("---------------------");
            }


            var filename = "clients.txt";
            var path = @$"C:\Users\Vartotojas\source\repos\Lesson-15\OrdersSistem(nr.4)\{filename}";
            File.WriteAllLines(path, clientList);
        }
        
    }
}
