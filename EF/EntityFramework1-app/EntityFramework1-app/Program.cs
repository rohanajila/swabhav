using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework1_app.Model;

namespace EntityFramework1_app
{
    class Program
    {
        public static SwabhavDbContext db = new SwabhavDbContext();
        static void Main(string[] args)
        {
            /*var d1 = new Dept { DeptId = 101, Name = "IT", Location = "Mumbai" };

            var e1 = new Emp { EmpId = 1, Name = "rohan", Salary = 12000 };
            var e2 = new Emp { EmpId = 2, Name = "ashar", Salary = 20000 };
            var e3 = new Emp { EmpId = 3, Name = "saurabh", Salary = 24000 };

            e1.dept = d1;
            e2.dept = d1;
            e3.dept = d1;

            d1.DeptEmployees.Add(e1);
            d1.DeptEmployees.Add(e2);
            d1.DeptEmployees.Add(e3);

            db.departments.Add(d1);

            db.SaveChanges();*/
            Query1();
            Console.ReadKey();
        }
        private static void Query1()
        {
            var dept = db.departments.Join(db.employees, depts => depts.DeptId, emp => emp.EmpId, (depts, emp) =>new
            {
                emp.Name,
                emp.Salary,
                depts.DeptId,
                depts.Location
            });
            foreach(var d in dept)
            {
                Console.WriteLine("Emplyee Name: " + d.Name + " Salary:" + d.Salary + " Dept Id:" + d.DeptId + " Location:" + d.Location);
            }
        }
    }
}
