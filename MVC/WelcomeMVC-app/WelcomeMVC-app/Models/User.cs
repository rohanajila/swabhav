using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WelcomeMVC_app.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
    }
}