using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternEvent.Publisher;

namespace ObserverPatternEvent.Subscriber
{
    public interface IListner
    {
        void update(Account account, string message, double amount);
    }
}
