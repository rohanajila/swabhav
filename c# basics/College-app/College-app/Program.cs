using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using College_app.Model;

namespace College_app
{
    class Program
    {
        static void Main(string[] args)
        {
            College college = new College("KKW","Panchvati, Nashik");
            Student student = new Student(college, "rohan", "KKW1", 'C');
            PrintStudentInfo(student);
            College college1 = new College("TILAK", "Vashi, Navi Mumbai");
            PrintCollegeInfo(college1);
            Console.Read();
        }
        public static void PrintCollegeInfo(College obj)
        {
            Console.WriteLine("------------COLLEGE INFO--------------");
            Console.WriteLine("Name of College: " + obj.Name);
            Console.WriteLine("Address of College: " + obj.Address);
            Console.WriteLine("\n");
        }

        public static void PrintStudentInfo(Student obj)
        {
            Console.WriteLine("------------COLLEGE INFO--------------");
            Console.WriteLine("Name of College: " + obj.getcollege.Name);
            Console.WriteLine("Address of College: " + obj.getcollege.Address);
            Console.WriteLine("------------STUDENT INFO--------------");
            Console.WriteLine("Name of Student: " + obj.StudentName);
            Console.WriteLine("Student ID: " + obj.StudentId);
            Console.WriteLine("Student Division: " + obj.Division);
            Console.WriteLine("\n");
        }
    }
}
