using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeMVC.Models;

namespace EmployeeMVC.Service
{
    public class EmployeeService
    {
        private static EmployeeService _employeeService;
        private List<Employee> _employees = new List<Employee>(); 

        public static EmployeeService GetInstance
        {

            get
            {
                if (_employeeService == null)
                {
                    _employeeService = new EmployeeService();
                    _employeeService.CreateEmployees();
                }
                return _employeeService;
            }
        }
        public void CreateEmployees()
        {
            _employees.Add(new Employee() { ID = 101, Name = "Rohan Ajila", Designation = "Developer", Salary = 12000 });
            _employees.Add(new Employee() { ID = 102, Name = "Saurabh Dutta", Designation = "HR", Salary = 10000 });
            _employees.Add(new Employee() { ID = 103, Name = "Arshdeep Singh", Designation = "Manager", Salary =25000 });
            _employees.Add(new Employee() { ID = 104, Name = "Akash Bhallal", Designation = "Sales", Salary = 12500 });
        }
        public List<Employee> GetEmployees()
        {           
            return _employees;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public void EditEmployee(Employee employee)
        {
            Employee emp = _employees.Where(x => x.ID == employee.ID).SingleOrDefault();
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Designation = employee.Designation;
        }
    }
}