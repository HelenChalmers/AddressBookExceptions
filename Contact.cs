using System;

namespace Exceptions
{
    public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }
    public string Email { get; set; }
    public string Address { get; set; }

    // public Contact (string firstname, string lastname, string email, string address)
    // {
    //     FirstName = firstname;
    //     LastName = lastname;
    //     Email = email;
    //     Address = address;
    // }

}

}