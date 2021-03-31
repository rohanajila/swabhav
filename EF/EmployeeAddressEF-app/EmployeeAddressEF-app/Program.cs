using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAddressEF_app.Model;

namespace EmployeeAddressEF_app
{
    class Program
    {
        public static SwabhavDbContext db = new SwabhavDbContext();
        static void Main(string[] args)
        {
           //CreateTable();
           Query1();
           Query2();
           Query3();
           Query4();
           Query5();
           Query6();
            Console.ReadKey();
        }
        private static void Query1()
        {
            Console.WriteLine("\nQuery1:top 3 employees with maximum salary\n");
            var maxsal = db.employees.OrderByDescending(e => e.Salary).Take(3);
            foreach(var s in maxsal)
            {
                Console.WriteLine("Name: "+s.Ename+" | Salary:"+s.Salary);
            }
                
           
        }
        private static void Query2()
        {
            Console.WriteLine("\nQuery2:Designation Wise Employee\n");
            var demp = db.employees.OrderBy(e => e.Designation).ToList();
            foreach (var s in demp)
            {
                Console.WriteLine("Name: "+s.Ename+" | Designation: "+s.Designation);
            }
        }
        private static void Query3()
        {
            Console.WriteLine("\nQuery3:employee with address if any\n");
            var result = db.employees.Join(db.addresses,
                e => e.Eid,
                a => a.Eid.Eid,
                (e, a) => new { e.Ename, a.Addrs });
            foreach(var r in result)
            {
                Console.WriteLine("Employee Name: " + r.Ename + " | Employee Address: " + r.Addrs);
            }
        }
       
        private static void Query4()
        {
            Console.WriteLine("\nQuery4: find all employees whose designation is clerk and salary is greater than 5000\n");
            var result = db.employees.Where(x => x.Designation == "Clerk" && x.Salary >= 5000).ToList();
            foreach(var e in result)
            {
                Console.WriteLine("Employee Name: " + e.Ename + " | Designation: " + e.Designation + " | Salary: " + e.Salary);
            }
        }
        private static void Query5()
        {
            Console.WriteLine("\nQuery5: employee of mumbai ");
            var result = db.employees.Join(db.addresses,
                e => e.Eid,
                a => a.Eid.Eid,
                (e, a) => new
                {
                    e.Ename,
                    a.Addrs
                }).Where(x => x.Addrs.Equals("Mumbai"));
            foreach(var r in result)
            {
                Console.WriteLine("Employee Name: " + r.Ename + " | Employee Address: " + r.Addrs);
            }
        }
        private static void Query6()
        {
            Console.WriteLine("\nQuery6: employee of mumbai or delhi");
            var result = db.employees.Join(db.addresses,
                e => e.Eid,
                a => a.Eid.Eid,
                (e, a) => new
                {
                    e.Ename,
                    a.Addrs
                }).Where(x => x.Addrs.Equals("Mumbai")||x.Addrs.Equals("Delhi"));
            foreach (var r in result)
            {
                Console.WriteLine("Employee Name: " + r.Ename + " | Employee Address: " + r.Addrs);
            }
        }
        private static void CreateTable()
        {
            var e1 = new Employee { Eid = 105, Ename = "vishal", Designation="Developer", Salary=12000 };
            
            var a1 = new Address {Aid=4,Addrs="Delhi" };
            

            a1.Eid = e1;
            

            e1.EAddress.Add(a1);
           

            db.employees.Add(e1);
            

            db.SaveChanges();
            Console.WriteLine("Table created Succesfully");
        }
    }
}
