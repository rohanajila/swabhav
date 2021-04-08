using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loginDemo1_app.Models;
using loginDemo1_app.Service;
using System.Diagnostics;

namespace loginDemo1_app.Controllers
{
    
    public class HomeController : Controller
    {
        public HomeController()
        {
            Debug.WriteLine("inside controller");
        }
        // GET: Home
      
        public ActionResult Index()
        {
            /* if (Session["CurrentSession"] == null)
             {
                 return View();
             }
             Employee employee = (Employee)Session["CurrentSession"];
             return RedirectToAction("HomePage", employee);*/
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
                        Session["CurrentSession"] = employee;
                        return RedirectToAction("HomePage", new Employee { Username = employee.Username, Password = employee.Password });
                    }
                }
                ViewBag.ErrorContent="username or password is incorrect";
            }
            return View(employee);
        }
        [CustomAuthentication]
        public ActionResult HomePage(Employee employee)
        {
           /* if (Session["CurrentSession"] == null)
            {
                return RedirectToAction("Index");
            }*/
            return View(employee);            
        }
    }
}