using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskTableMVC_app.Models;
using TaskTableMVC_app.Repository;

namespace TaskTableMVC_app.Service
{
    public class UserService
    {
        private static UserService _userService;
        private UserRepository repository = new UserRepository(new TaskDbContext());

        public static UserService GetInstance
        {
            get
            {
                if (_userService == null)
                {
                    _userService = new UserService();
                }
                return _userService;
            }
        }

        public void AddUser(User user)
        {
            repository.AddUser(user);
        }
               

        public List<User> GetUsers()
        {
            return repository.GetUsers();
        }

        public User GetUserByID(int id)
        {
            return repository.GetUserByID(id);
        }
     
    }
}