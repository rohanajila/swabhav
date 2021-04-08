using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTableMVC_app.Models;

namespace TaskTableMVC_app.Repository
{
    interface IUserRepository
    {
        List<User> GetUsers();
        void AddUser(User user); 
       
        User GetUserByID(int id);
    }
}
