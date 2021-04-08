using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactEF_MVC_app.Models;

namespace ContactEF_MVC_app.Repository
{
    public class UserRepository:IUserRepository
    {
        public ContactDbContext db;
        public UserRepository(ContactDbContext db)
        {
            this.db = db;
        }
        public User GetUserByID(int id)
        {
            return db.Users.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }
        public void DeleteUser(int id)
        {
            db.Users.Remove(db.Users.Where(x => x.Id == id).SingleOrDefault());
            db.SaveChanges();
        }
        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}