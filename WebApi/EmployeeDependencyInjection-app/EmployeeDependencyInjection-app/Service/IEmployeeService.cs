using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDependencyInjection_app.Models;

namespace EmployeeDependencyInjection_app.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

    }
}
