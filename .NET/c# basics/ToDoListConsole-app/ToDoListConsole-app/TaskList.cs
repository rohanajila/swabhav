using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListConsole_app
{
    class TaskList
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public DateTime DateTime { get; set; }
        public TaskListStatus Status { get; set; }
    }
}
