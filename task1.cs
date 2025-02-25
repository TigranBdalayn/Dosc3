// Task 1: Phone Book
// Task: Create a Contact class with:
// Name, PhoneNumber, and Email properties.
// A method DisplayInfo() to print contact details.
// A Main() method where the user can create 3 contacts and display them.
// Store contacts in an array and allow searching by name.

using System;

class Contact {
    public string Name {get; set;}
    public string PhoneNumber {get; set;}
    public string Email {get; set;}

    public Contact (string name , string phoneNumber , string mail) {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = mail;
    }
    public void DisplayInfo () {
        Console.WriteLine ("Name: " + Name);
        Console.WriteLine ("PhoneNumber: " + PhoneNumber);
        Console.WriteLine ("Email: " + Email);
        Console.WriteLine ();
    }
}

class Program {
    static void Main(string[] args) {



        Contact[] contacts = new Contact[3];

        for (int i = 0; i < contacts.Length; ++i) {
            Console.Write("Please Enter Name ");
            string name =  Console.ReadLine ();
            Console.Write ("Please Enter PhoneNumber ");
            string phoneNumber = Console.ReadLine ();
            Console.Write ("Please Enter Email ");
            string email = Console.ReadLine ();
            contacts[i] = new Contact (name, phoneNumber, email);
            Console.WriteLine ("Contact Add succesfulluy\n");
        }

        Console.WriteLine ("\nEnter Contact Nume to search ");
        string SearchName = Console.ReadLine ();

        for (int i = 0; i < contacts.Length; ++i) {
            if (contacts[i].Name.Equals(SearchName)) {
                Console.WriteLine ("Contact is found");
                contacts[i].DisplayInfo ();
                break;
            }
            if (i == contacts.Length - 1) {
                Console.WriteLine ("Contact not found");
            }
             
        }
 
    }
} 