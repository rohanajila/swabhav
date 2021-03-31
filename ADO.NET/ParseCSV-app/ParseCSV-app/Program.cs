using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ParseCSV_app.Model;

namespace ParseCSV_app
{
    class Program
    {
        static void Main(string[] args)
        {

            var employees = LoadEmployee("employee.csv");
            Console.WriteLine("All Employess:\n");
            foreach(var employee in employees)
            {
                Console.WriteLine(employee.EmpNo + " " + employee.EName);
            }
            var departments = LoadDepartment("dept.csv");
            Console.WriteLine("\nAll departments:\n");
            foreach(var department in departments)
            {
                Console.WriteLine(department.DeptNo + " " + department.DName+" "+department.Loc);
            }

            var e = LoadEmployee("employee.csv").Where(row => row.DeptNo == 20);
            Console.WriteLine("\nEmployess with dept no.=20\n");
            foreach (var employee in e)
            {
                Console.WriteLine(employee.EmpNo + " " + employee.EName+" "+employee.DeptNo);
            }
           
            Console.ReadKey();
        }

        private static List<Employee> LoadEmployee(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(Employee.ParseRow).ToList();
        }
        private static List<Department> LoadDepartment(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(Department.ParseRow).ToList();
        }
    }
}
