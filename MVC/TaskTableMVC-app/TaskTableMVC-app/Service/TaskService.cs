using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskTableMVC_app.Repository;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app.Service
{
    public class TaskService
    {
        private static TaskService _taskService;
        private TaskRepository repository = new TaskRepository(new TaskDbContext());

        public static TaskService GetInstance
        {
            get
            {
                if (_taskService == null)
                {
                    _taskService = new TaskService();
                }
                return _taskService;
            }
        }

        public void AddTask(Tasks task)
        {
            repository.AddTasks(task);
        }

        public void DeleteTask(int id)
        {
            repository.DeleteTasks(id);
        }

        public List<Tasks> GetTasks()
        {
            return repository.GetTasks();
        }
       
        public Tasks GetTaskByID(int id)
        {
            return repository.GetTaskByID(id);
        }

        public void UpdateTask(Tasks task)
        {
            repository.EditTasks(task);
        }
    }
}