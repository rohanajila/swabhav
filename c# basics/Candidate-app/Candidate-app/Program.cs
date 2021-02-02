using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate obj1 = new Candidate();
            Candidate obj2 = new Candidate();
            Candidate obj3 = new Candidate();
            Candidate obj4 = new Candidate();
            Console.WriteLine("Enter the details for Candidate 1:");
            obj1.setId();
            obj1.setName();
            obj1.setGrade();
            obj1.setAge();
            Console.WriteLine("Enter the details for Candidate 2:");
            obj2.setId();
            obj2.setName();
            obj2.setGrade();
            obj2.setAge();
            obj3 = obj3.compareGrade(obj1, obj2);
            display(obj3);
            obj4 = obj4.compareAge(obj1, obj2);
            Console.WriteLine(obj4.getName() + " is older than the other candidate! ");
            Console.ReadLine();



        }
        public static void display(Candidate obj)
        {
            Console.WriteLine("ID :" + obj.getId());
            Console.WriteLine("Name :" + obj.getName());
            Console.WriteLine("Grade :" + obj.getGrade());
        }
    }
}
