﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContactEF_MVC_app.Models;

namespace ContactEF_MVC_app.DBContext
{
    public class ContactDbContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}