using System;

namespace OrderSistem_Business
{
    public class Client
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Adress { get; }
        public string Email { get; }
        

        public Client (string firstName, string lastName, string adress, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            Email = email;
            
        }
    }
}
