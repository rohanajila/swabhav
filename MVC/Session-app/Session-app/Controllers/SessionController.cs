using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Session_app.ViewModel;

namespace Session_app.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            StateViewModel svm;
            if(Session["CurrentSession"]!=null)
            {
                svm = (StateViewModel)Session["CurrentSession"];
            }
            else
            {
                svm = new StateViewModel();
            }

            svm.OldValue = svm.Counter;
            svm.Counter++;
            svm.NewValue = svm.Counter;

            Session["CurrentSession"] = svm;
            return View(svm);
        }
    }
}