using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Contact_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to Contact-app");
            do
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1.Add Contact Data\n2.Display Contact Data\n3.Modify Contact Data\n4.Delete Contact Data\n5.Exit");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Contact obj = new Contact("Rohan", "Ajila", 9619758520, "rohanajila@gmail.com");
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream(@"D:\xampleNew.txt", FileMode.Create, FileAccess.Write);
                        formatter.Serialize(stream, obj);
                        stream.Close();
                        break;
                    case 2:
                        IFormatter formatters= new BinaryFormatter();
                        stream = new FileStream(@"D:\xampleNew.txt", FileMode.Open, FileAccess.Read);
                        Contact  objnew = (Contact)formatters.Deserialize(stream);
                        PrintInfo(objnew);
                        
                        break;
                       
                }
            } while (choice != 5);
            Console.ReadKey();
        }
        public static void PrintInfo(Contact obj)
        {
            Console.WriteLine("First Name: " + obj.Fname);
            Console.WriteLine("Last Name: " + obj.Lname);
            Console.WriteLine("Contact no.: " + obj.Phone_no);
            Console.WriteLine("Email id: " + obj.Email_id);
        }
    }
}
