using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskTableMVC_app.Models
{
    [Table("SubTask")]
    public class Subtask
    {
        public int ID { get; set; }
        public string TaskDetail { get; set; }
        public DateTime DOI { get; set; }
        public string Status { get; set; }
        public virtual Tasks Task { get; set; }
    }
}