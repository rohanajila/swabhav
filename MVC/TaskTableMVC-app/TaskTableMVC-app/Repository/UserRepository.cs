using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app.Repository
{
    public class UserRepository:IUserRepository
    {
        public TaskDbContext db;

        public UserRepository(TaskDbContext db)
        {
            this.db = db;
        }

        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
       

        public User GetUserByID(int id)
        {
            return db.Users.Where(x => x.ID == id).SingleOrDefault();
        }

        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }
    }
}