using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app.Repository
{
    public class TaskRepository:ITaskRepository
    {
        public TaskDbContext db;

        public TaskRepository(TaskDbContext db)
        {
            this.db = db;
        }

        public void AddTasks(Tasks tasks)
        {
            db.Tasks.Add(tasks);
            db.SaveChanges();
        }

        public void DeleteTasks(int id)
        {
            db.Tasks.Remove(db.Tasks.Where(x => x.ID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public void EditTasks(Tasks tasks)
        {
            Tasks task = db.Tasks.Where(x => x.ID == tasks.ID).SingleOrDefault();
            task.TaskDetail = tasks.TaskDetail;
            task.DOI = DateTime.Now;
            task.Status = tasks.Status;
            db.SaveChanges();
        }

        public Tasks GetTaskByID(int id)
        {
            return db.Tasks.Where(x => x.ID == id).SingleOrDefault();
        }

        public List<Tasks> GetTasks()
        {
            return db.Tasks.ToList();
        }
    }
}