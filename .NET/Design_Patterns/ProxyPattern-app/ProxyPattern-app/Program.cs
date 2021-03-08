using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyPattern_app.Model;

namespace ProxyPattern_app
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountProxy a = new AccountProxy("SBI10205", "Rohan", 30000);
            a.Deposit(1000);
            Console.Read();
        }
    }
}
