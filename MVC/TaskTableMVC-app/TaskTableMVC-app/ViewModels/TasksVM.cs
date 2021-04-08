using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskTableMVC_app.Models;
using System.ComponentModel.DataAnnotations;

namespace TaskTableMVC_app.ViewModels
{
    public class TasksVM
    {
        public int ID { get; set; }
        [Required]
        public string TaskDetails { get; set; }
        public DateTime DOI { get; set; }
        [Required]
        public string Status { get; set; }
    }
}