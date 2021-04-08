using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactEF_MVC_app.Repository;
using ContactEF_MVC_app.Models;

namespace ContactEF_MVC_app.Service
{
    public class UserService
    {
        private static UserService _userService;
        private UserRepository repository = new UserRepository(new ContactDbContext());

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

        public void DeleteUser(int id)
        {
            repository.DeleteUser(id);
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