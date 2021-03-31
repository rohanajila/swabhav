using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactStoreEF_app.Repository;
using ContactStoreEF_app.Model;

namespace ContactStoreEF_app
{
    class Program
    {
        private const int ADD = 1;
        private const int MODIFY = 2;
        private const int SEARCH = 3;
        private const int DELETE = 4;
        private const int EXIT = 5;

        static void Main(string[] args)
        {
            ContactEFRepository repository = new ContactEFRepository(new DBContext.ContactDbContext());

            int choice = 0;
            while(choice !=5)
            {
                Console.WriteLine("\n");
                foreach(var c in repository.GetContacts())
                {
                    Console.WriteLine("ID: " + c.Id + ", First Name: " + c.FirstName + ", Last Name: " + c.LastName + ", PhoneNo.: " + c.PhoneNo);
                }
                Console.WriteLine("\n1.Add Contact\n2.Modify Contact\n3.Search Contact\n4.Delete Contact\n5.Exit");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case ADD:
                        repository.AddContact(new Model.Contact{Id=1,FirstName="rohan",LastName="ajila",PhoneNo=1234 });
                        break;
                    case MODIFY:
                        Console.WriteLine("Enter the id you want to modify:");
                        int mid = int.Parse(Console.ReadLine());
                        Console.WriteLine("What do you want to modify:");
                        Console.WriteLine("\n1.First Name\n2.Last Name\n3.PhoneNo.");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the modification");
                        string mod = Console.ReadLine();
                        repository.EditContact(c, mid, mod);
                        break;
                    case SEARCH:
                        List<Contact> scontacts = new List<Contact>();
                        Console.WriteLine("Enter the contact name you want to search:");
                        string sname = Console.ReadLine();
                        scontacts=repository.SearchContact(sname);
                        foreach (var s in scontacts)
                        {
                            Console.WriteLine("ID: " + s.Id + ", First Name: " + s.FirstName + ", Last Name: " + s.LastName + ", PhoneNo.: " + s.PhoneNo);
                        }
                        break;
                    case DELETE:
                        Console.WriteLine("enter the contact id you want to delete:");
                        int did = int.Parse(Console.ReadLine());
                        repository.DeleteContact(did);
                        break;
                    case EXIT:
                        Console.WriteLine("\n\nEXITED!!");
                        break;
                    
                }
            }
            Console.ReadKey();
        }
    }
}
