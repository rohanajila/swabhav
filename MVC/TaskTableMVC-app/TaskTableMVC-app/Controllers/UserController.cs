using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using TaskTableMVC_app.ViewModels;
using TaskTableMVC_app.Models;
using TaskTableMVC_app.Service;

namespace TaskTableMVC_app.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserService userService = UserService.GetInstance;

       
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UsersVM userVM)
        {
            if (ModelState.IsValid)
            {
                userService.AddUser(new User
                {
                    Username = userVM.User.Username,
                    Password = userVM.User.Password,
                    Role = userVM.User.Role,
                });
                return RedirectToAction("Login");
            }
            return View(userVM);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                foreach (var user in userService.GetUsers())
                {
                    if (loginVM.Username == user.Username && loginVM.Password == user.Password)
                    {
                        FormsAuthentication.SetAuthCookie(loginVM.Username,false);                        
                        return RedirectToAction("Index", "Task");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid username or password");
            return View(loginVM);
        }       

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}