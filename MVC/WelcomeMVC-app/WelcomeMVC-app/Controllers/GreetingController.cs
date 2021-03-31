using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVC_app.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index()
        {
            ViewBag.currentTime = DateTime.Now.Hour;
            return View();
          
        }
    }
}