using System;

namespace OrderSistem_Business
{
    public class Client
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Adress { get; }

        public Client (string firstName, string lastName, string email, string adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Adress = adress;
        }
    }
}
