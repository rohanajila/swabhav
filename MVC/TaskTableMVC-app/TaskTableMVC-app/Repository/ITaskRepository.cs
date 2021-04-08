using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app.Repository
{
    interface ITaskRepository
    {
        List<Tasks> GetTasks();
        void AddTasks(Tasks tasks);
        void EditTasks(Tasks tasks);
        void DeleteTasks(int id);
        Tasks GetTaskByID(int id);
    }
}
