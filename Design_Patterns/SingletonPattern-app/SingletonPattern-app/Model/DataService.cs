using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern_app.Model
{
    class DataService
    {
        private static DataService bucket;
        private DataService()
        {
            Console.WriteLine("Service created");
        }
        public static DataService getInstance()
        {
            if (bucket == null)
                bucket = new DataService();
            return bucket;
        }
        public void ProcessData()
        {
            Console.WriteLine("Hash code of current Data Service is: " + this.GetHashCode());
        }
    }
}
