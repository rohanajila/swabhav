using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactEF_MVC_app.ViewModels;
using ContactEF_MVC_app.Service;
using ContactEF_MVC_app.Models;

namespace ContactEF_MVC_app.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        ContactService contactService = ContactService.GetInstance;
        public ActionResult Index()
        {
            ContactVM contactVM = new ContactVM();
            contactVM.Contacts = contactService.GetContacts();                       
            return View(contactVM);
        }

        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(AddContactVM contactVM)
        {
            if (ModelState.IsValid)
            {
                contactService.AddContact(new Contact
                {
                    FirstName = contactVM.FirstName,
                    LastName = contactVM.LastName,
                    PhoneNo = contactVM.PhoneNo,
                    Address = contactVM.Address
                });
                return RedirectToAction("Index");
            }
            return View(contactVM);
        }

        public ActionResult UpdateContact(int id)
        {
            EditContactVM contactVM = new EditContactVM();
            contactVM.Contact = contactService.GetContactByID(id);
            return View(contactVM);
        }

        [HttpPost]
        public ActionResult UpdateContact(EditContactVM contactVM)
        {
            if (ModelState.IsValid)
            {
                contactService.UpdateContact(contactVM.Contact);
                return RedirectToAction("Index");
            }
            return View(contactVM);
        }

        public ActionResult DeleteContact(int id)
        {
            contactService.DeleteContact(id);
            return RedirectToAction("Index");
        }
    }
}