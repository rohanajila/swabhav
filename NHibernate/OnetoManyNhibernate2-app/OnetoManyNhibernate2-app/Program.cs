using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnetoManyNhibernate2_app.Model;

namespace OnetoManyNhibernate2_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateTable();
            // HighestSalaryInEachDepartment();
            FindEmployeeByDepartmentId();
            Console.ReadKey();
        }
        private static void CreateTable()
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    var dept = new Dept
                    {
                        DeptId = 1,
                        Name = "IT",
                        Location="Mumbai"
                    };
                    var dept1 = new Dept
                    {
                        DeptId = 2,
                        Name = "HR",
                        Location="Pune"
                    };
                    var dept2 = new Dept
                    {
                        DeptId = 3,
                        Name = "Sales",
                        Location="Delhi"
                    };
                    var emp = new Emp
                    {
                        EmpId = 1,
                        Name = "Rohan",
                        Salary = 12000
                    };
                    var emp1 = new Emp
                    {
                        EmpId = 2,
                        Name = "Ashar",
                        Salary=15000
                    };
                    var emp2 = new Emp
                    {
                        EmpId = 3,
                        Name = "Saurabh",
                        Salary=25000

                    };
                    var emp3 = new Emp
                    {
                        EmpId = 4,
                        Name = "Arshdeep",
                        Salary=14000
                    };
                    emp.Dept = dept;
                    emp1.Dept = dept;
                    emp2.Dept = dept1;
                    emp3.Dept = dept2;

                    session.Save(dept);
                    session.Save(dept1);
                    session.Save(dept2);
                    session.Save(emp);
                    session.Save(emp1);
                    session.Save(emp2);
                    session.Save(emp3);
                    transaction.Commit();

                }

                //Console.ReadKey();
            }
            Console.WriteLine("Table created!");
        }
        public static void HighestSalaryInEachDepartment()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var departmentEmployees = session.Query<Dept>().GroupJoin(session.Query<Emp>(),
                        department => department.DeptId,
                        employee => employee.Dept.DeptId,
                        (department, employee) => new
                        {
                            departmentId = department.DeptId,
                            employeeDepartment = department.Name,
                            employeeSalary = employee.Max(x => x.Salary),
                        });

                    Console.WriteLine($"Displaying Highest salary in each department");
                    foreach (var departmentEmployee in departmentEmployees)
                    {
                        Console.WriteLine($"Department Id : {departmentEmployee.departmentId} | department Name : {departmentEmployee.employeeDepartment} | Salary : {departmentEmployee.employeeSalary}");
                    }
                }
            }
        }
        public static void FindEmployeeByDepartmentId()
        {
            
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Console.WriteLine("Enter the dept id you want :");
                    int code = int.Parse(Console.ReadLine());

                    var departmentEmployees = session.Query<Dept>().Join(session.Query<Emp>(),
                        department => department.DeptId,
                        employee => employee.Dept.DeptId,
                        (department, employee) => new
                        {
                            departmentId = department.DeptId,
                            employeeName = employee.Name,                            
                            employeeDepartment = department.Name,
                            employeeSalary = employee.Salary
                        }).Where(x => x.departmentId == (int)code);
                    Console.WriteLine($"Displaying Employee from Dept ID:{code.ToString()}");
                    foreach (var employeeData in departmentEmployees)
                    {
                        Console.WriteLine($"\nEmployee Name : {employeeData.employeeName} " +
                            $" | Employee Department : {employeeData.employeeDepartment}" +
                            $" | Employee Salary : {employeeData.employeeSalary}");
                    }
                }
            }
        }
    }
}
