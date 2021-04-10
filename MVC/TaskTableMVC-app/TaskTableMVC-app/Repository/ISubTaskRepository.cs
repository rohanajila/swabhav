using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app.Repository
{
    interface ISubTaskRepository
    {
        List<Subtask> GetSubTasks();
        void AddSubTasks(Subtask tasks);
        void EditSubTasks(Subtask tasks);
        void DeleteSubTasks(int id);
        Subtask GetSubTaskByID(int id);
    }
}
