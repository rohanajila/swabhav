using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactEF_MVC_app.Models;

namespace ContactEF_MVC_app.Repository
{
    interface IUserRepository
    {
        List<User> GetUsers();       
        void AddUser(User user);       
        void DeleteUser(int id);
        User GetUserByID(int id);
    }
}
