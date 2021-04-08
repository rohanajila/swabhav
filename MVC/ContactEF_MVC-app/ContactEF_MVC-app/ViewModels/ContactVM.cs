using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactEF_MVC_app.Models;

namespace ContactEF_MVC_app.ViewModels
{
    public class ContactVM
    {
        public List<Contact> Contacts { get; set; }
    }
}