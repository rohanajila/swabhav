using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskTableMVC_app.Models
{
    [Table("Tasks")]
    public class Tasks
    {
        [Key]
        public int ID { get; set; }
        public string TaskDetail { get; set; }
        public DateTime DOI { get; set; }
        public string Status { get; set; }
        public User User { get; set; }
        public virtual List<Subtask> Subtasks { get; set; }
        public Tasks()
        {
            Subtasks = new List<Subtask>();
        }

    }
}