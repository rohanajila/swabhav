using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeRouteDTOWebApi_app.Service;
using EmployeeRouteDTOWebApi_app.Models;
using EmployeeRouteDTOWebApi_app.DTO;

namespace EmployeeRouteDTOWebApi_app.Controllers
{
    [RoutePrefix("api/v1/employee")]
    public class HomeController : ApiController
    {
        EmployeeService employeeService = EmployeeService.GetInstance;
        [Route]
        public List<EmployeeDTO> Get()
        {
            return employeeService.GetEmployees().Select(x=>new EmployeeDTO (){Name=x.Name,Designation=x.Designation }).ToList();
        }
        [Route("{id:int}")]
        public Employee Get(int id)
        {
            return employeeService.GetEmployeeById(id);
        }
        [Route]
        public IHttpActionResult Post([FromBody] Employee employee)
        {
            employeeService.AddEmployee(new Employee
            {
                Id = employee.Id,
                Name = employee.Name,
                Designation = employee.Designation,
                Salary = employee.Salary
            });
            return Ok("Added Succesfully");
        }
        [Route("{id:int}")]
        public IHttpActionResult Put(int id, [FromBody] Employee employee)
        {
            employeeService.EditEmployee(id, employee);
            return Ok("Updated Successfully");
        }
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            employeeService.DeleteEmployee(id);
            return Ok("Deleted Succesfully");
        }
    }
}
