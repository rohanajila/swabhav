using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_app.Model;

namespace Library_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Trilogy", "Lower Parel, Mumbai");
           
            Books book = new Books(library, "Head First OOAD", "T01245", new DateTime(2010, 7, 10, 7, 10, 24));
            PrintBooksInfo(book);
            Library library1 = new Library("British Council Library", "Elphinstone Road, Mumbai");
           
            Books book1 = new Books(library, "Head First OOAD", "T01245", new DateTime(2015, 10, 10, 9, 10, 34));
            PrintBooksInfo(book1);
            Console.Read();
        }
     
        public static void PrintBooksInfo(Books obj)
        {
            Console.WriteLine("------------LIBRARY INFO--------------");
            Console.WriteLine("Name of Library: " + obj.getlibrary.Name);
            Console.WriteLine("Address of Library: " + obj.getlibrary.Address);
            Console.WriteLine("------------BOOKS INFO--------------");
            Console.WriteLine("Name of Book: " + obj.BookName);
            Console.WriteLine("Book ID: " + obj.BookId);
            Console.WriteLine("Date of issue: " + obj.IssueDate);
            Console.WriteLine("\n");
        }
    }
}
