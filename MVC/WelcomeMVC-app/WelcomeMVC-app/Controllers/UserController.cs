using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVC_app.Models;

namespace WelcomeMVC_app.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult GetDetails(User collection)
        {
            ViewData["userId"] = collection.Id;
            ViewData["userName"] = collection.Name;
            return View();
        }
        
    }
}