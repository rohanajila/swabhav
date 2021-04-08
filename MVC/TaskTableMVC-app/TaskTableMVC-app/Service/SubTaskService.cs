using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskTableMVC_app.Models;
using TaskTableMVC_app.Repository;

namespace TaskTableMVC_app.Service
{
    public class SubTaskService
    {
        private static SubTaskService _taskService;
        private SubTaskRepository repository = new SubTaskRepository(new TaskDbContext());

        public static SubTaskService GetInstance
        {
            get
            {
                if (_taskService == null)
                {
                    _taskService = new SubTaskService();
                }
                return _taskService;
            }
        }

        public void AddSubTask(Subtask task)
        {
            repository.AddSubTasks(task);
        }

        public void DeleteSubTask(int id)
        {
            repository.DeleteSubTasks(id);
        }

        public List<Subtask> GetSubTasks(int id)
        {
            return repository.GetSubTasks(id);
        }

        public Subtask GetSubTaskByID(int id)
        {
            return repository.GetSubTaskByID(id);
        }

        public void UpdateSubTask(Subtask task)
        {
            repository.EditSubTasks(task);
        }
    }
}