using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern_app.Model
{
    public interface IListner
    {
        void update(Account account,string message,double amount);
    }
}
