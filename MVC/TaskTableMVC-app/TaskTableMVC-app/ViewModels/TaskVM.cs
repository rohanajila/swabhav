﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskTableMVC_app;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app.ViewModels
{
    public class TaskVM
    {
        public List<Tasks> Tasks { get; set; }
    }
}