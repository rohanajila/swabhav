using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using loginDemo1_app.Models;

namespace loginDemo1_app.Service
{
    public class EmployeeService
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Username = "rohan",Password="rohan123"},
                new Employee { Username = "ashar",Password="ashar123"},
                new Employee { Username = "saurabh",Password="saurabh123"},
                new Employee { Username = "admin",Password="admin"}
            };
            return employees;
        }
    }
}