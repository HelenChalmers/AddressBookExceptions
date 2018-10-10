using System;
using System.Collections.Generic;

namespace Exceptions
{
    public class AddressBook {

        public  Dictionary<string, Contact> AddressBooks = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            AddressBooks.Add(contact.Email, contact);
        }
        // GetByEmail
        public Contact GetByEmail(string email)
        {
            return AddressBooks[email];
        }

    }
}