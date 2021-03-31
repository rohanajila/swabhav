using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleEntityFramework_app.Model;

namespace SimpleEntityFramework_app
{
    class Program
    {
        public static DemoDbContext db = new DemoDbContext();
        static void Main(string[] args)
        {
            // CreateEmployee();
            //AddEmployee();
            // DeleteEmployee();
            //UpdateEmployee();
            Case2();

            Console.ReadKey();
        }
        private static void CreateEmployee()
        {
            Employee[] employees = {new Employee { ID=101,Name="rohan",Salary=150.50},
            new Employee { ID=102,Name="ashar",Salary=150.50},
            new Employee { ID=103,Name="saurabh",Salary=150.50} };
            foreach (Employee emp in employees)
                db.Employees.Add(emp);
            db.SaveChanges();
        }
        private static void AddEmployee()
        {
            
            db.Employees.Add(new Employee { ID = 104, Name = "vishal", Salary = 200.50 });
            db.SaveChanges();
            Console.WriteLine("Record added successfully");
        }
        private static void DeleteEmployee()
        {
            foreach(var e in db.Employees)
            {
                if (e.Name.Equals("saurabh"))
                {
                    db.Employees.Remove(e);
                    Console.WriteLine("Record Deleted Succesfully");
                }                    
                else
                    Console.WriteLine("Employee ID={0}, Name={1}", e.ID, e.Name);
            }
            db.SaveChanges();
        }
        private static void UpdateEmployee()
        {
            foreach(var e in db.Employees)
            {
                Console.WriteLine("Emplyee ID={0}, Name={1}, Salary={2}", e.ID, e.Name, e.Salary);
                if(e.Name.Equals("rahul"))
                {
                    e.Name = "rohan";
                }
                  //  db.Employees.
            }
            db.SaveChanges();

        }
        private static void Case1()
        {
            var emp = db.Employees.
                ToList().   
                Where(e => e.Salary > 160).
                Select(e => new { e.Name, e.Salary });
            foreach(var e in emp)
            {
                Console.WriteLine("Name={0}, Salary={1}",e.Name, e.Salary);
            }

        }
        private static void Case2()
        {
            var emp = db.Employees.
             Where(e => e.Salary > 160).
             Select(e => new { e.Name, e.Salary }).
             ToList();
            foreach (var e in emp)
            {
                Console.WriteLine("Name={0}, Salary={1}", e.Name, e.Salary);
            }
        }
    }
}
