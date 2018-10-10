using System;
using System.Collections.Generic;

namespace Exceptions
{
    public class AddressBook {

        public  Dictionary<string, Contact> AddressBooks = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        
        {
            try 
            {
                AddressBooks.Add(contact.Email, contact);
            } catch (ArgumentException ex) 
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"This contact was already added {ex.Message}");
            }


            
        }
        // GetByEmail
        public Contact GetByEmail(string email)
        {
            return AddressBooks[email];
        }

    }
}