using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Session_app.ViewModel;

namespace Session_app.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            StateViewModel svm;

            if(HttpContext.Application["CurrentSession"]!=null)
            {
                svm = (StateViewModel)HttpContext.Application["CurrentSession"];
            }
            else
            {
                svm = new StateViewModel();
            }

            svm.OldValue = svm.Counter;
            svm.Counter++;
            svm.NewValue = svm.Counter;

            HttpContext.Application["CurrentSession"] = svm;
            return View(svm);
        }
    }
}