using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVC_app.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public HomeController()
        {
            
        }
        public ActionResult Index()
        {

            return View();
           
        }
        public ActionResult Hello()
        {
            return View();
        }
        public ActionResult Msg(string name)
        {
            ViewBag.msg = name;
            return View();
        }
        public ActionResult Textbox(string username)
        {
            ViewBag.username = username;
            return View();
        }

        public ActionResult TextboxMultipleTimes(string username)
        {
            ViewBag.username = username;
            return View();
        }

        public ActionResult TwoTextBox(string firstname, string lastname)
        {
            ViewBag.firstname = firstname;
            ViewBag.lastname = lastname;
            return View();
        }
        public ActionResult FetchColorFromDropDown(string colors)
        {
            ViewBag.colors = colors;
            return View();
        }
        public ActionResult FetchDepartmentFromDropDown(FormCollection Department)
        {
            ViewBag.dropdown_value = Department[0];
            return View();
        }
    }
}