using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees=new List<Employee>();
            employees.Add(new Employee(1, "rohan", 25000, "manager"));
            employees.Add(new Employee(2, "ashar", 15000, "employee"));
            employees.Add(new Employee(3, "saurabh", 10000, "emaployee"));

            IEnumerable<Employee> employees1=employees;
           
            var employeeList = employees1.OrderBy(x => x.Salary);
            Console.WriteLine("Employess list sorted by salary:");
            foreach(var em in employeeList)
            {
                Console.WriteLine(em.Name);
            }
            Console.ReadKey();

        }
    }
}
