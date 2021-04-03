using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loginDemo1_app.Models;
using loginDemo1_app.Service;

namespace loginDemo1_app.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            if (ModelState.IsValid)
            {
                foreach (var emp in EmployeeService.GetEmployees())
                {
                    if (employee.Username == emp.Username && employee.Password == emp.Password)
                    {
                        return RedirectToAction("HomePage", new Employee { Username = employee.Username, Password = employee.Password });
                    }
                }
                ViewBag.ErrorContent="username or password is incorrect";
            }
            return View(employee);
        }

        public ActionResult HomePage(Employee employee)
        {
            return View(employee);
        }
    }
}