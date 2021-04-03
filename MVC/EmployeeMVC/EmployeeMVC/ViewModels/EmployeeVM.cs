using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeMVC.Models;

namespace EmployeeMVC.ViewModels
{
    public class EmployeeVM
    {
        public List<Employee> Employees { get; set; }
    }
}