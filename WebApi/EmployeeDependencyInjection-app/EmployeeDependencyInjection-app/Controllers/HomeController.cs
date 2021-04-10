using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDependencyInjection_app.Service;
using EmployeeDependencyInjection_app.Models;

namespace EmployeeDependencyInjection_app.Controllers
{
    public class HomeController : ApiController
    {
        IEmployeeService _service = null;
        public HomeController(IEmployeeService service)
        {
            _service = service;
        }

        public List<Employee> GetEmployees()
        {
            return _service.GetEmployees();
        }
    }
}
