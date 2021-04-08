using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app
{
    public class TaskDbContext:DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Subtask> SubTasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}