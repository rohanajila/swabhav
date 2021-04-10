using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDependencyInjection_app.Models;

namespace EmployeeDependencyInjection_app.Service
{
    public class EmployeeService:IEmployeeService
    {
        private List<Employee> _employees = new List<Employee>();
        public List<Employee> GetEmployees()
        {
            _employees.Add(new Employee() { Id = 101, Name = "Rohan Ajila", Designation = "Developer", Salary = 12000 });
            _employees.Add(new Employee() { Id = 102, Name = "Saurabh Dutta", Designation = "HR", Salary = 10000 });
            _employees.Add(new Employee() { Id = 103, Name = "Arshdeep Singh", Designation = "Manager", Salary = 25000 });
            _employees.Add(new Employee() { Id = 104, Name = "Akash Bhallal", Designation = "Sales", Salary = 12500 });
            return _employees;
        }
    }
}