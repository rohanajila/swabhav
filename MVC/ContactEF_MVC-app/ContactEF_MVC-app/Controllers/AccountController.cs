using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactEF_MVC_app.Models;
using ContactEF_MVC_app.Service;
using System.Web.Security;

namespace ContactEF_MVC_app.Controllers
{
    public class AccountController : Controller
    {
        UserService userService = UserService.GetInstance;
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            foreach(var u in userService.GetUsers())
            {
                if(u.UserName==user.UserName&&u.Password==user.Password)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid username or password");
            }
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User user)
        {
            if (ModelState.IsValid)
            {
                userService.AddUser(new User
                {
                    UserName = user.UserName,
                    Password = user.Password,
                });
                return RedirectToAction("Login");
            }
            return View(user);
            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}