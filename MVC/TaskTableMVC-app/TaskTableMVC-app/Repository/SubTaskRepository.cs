using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app.Repository
{
    public class SubTaskRepository:ISubTaskRepository
    {
        public TaskDbContext db;

        public SubTaskRepository(TaskDbContext db)
        {
            this.db = db;
        }

        public void AddSubTasks(Subtask tasks)
        {
            db.SubTasks.Add(tasks);
            db.SaveChanges();
        }

        public void DeleteSubTasks(int id)
        {
            db.SubTasks.Remove(db.SubTasks.Where(x => x.ID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public void EditSubTasks(Subtask tasks)
        {
            Subtask task = db.SubTasks.Where(x => x.ID == tasks.ID).SingleOrDefault();
            task.TaskDetail = tasks.TaskDetail;
            task.DOI = DateTime.Now;
            task.Status = tasks.Status;
            db.SaveChanges();
        }

        public Subtask GetSubTaskByID(int id)
        {
            return db.SubTasks.Where(x => x.ID == id).SingleOrDefault();
        }
        public List<Subtask> GetSubTasks(int id)
        {
            return db.SubTasks.Where(x => x.Task.ID == id).ToList();
        }
    }
}