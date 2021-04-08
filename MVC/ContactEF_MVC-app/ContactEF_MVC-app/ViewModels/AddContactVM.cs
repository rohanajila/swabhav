using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ContactEF_MVC_app.Models;

namespace ContactEF_MVC_app.ViewModels
{
    public class AddContactVM
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public long PhoneNo { get; set; }
        [Required]
        public string Address { get; set; }
    }
}