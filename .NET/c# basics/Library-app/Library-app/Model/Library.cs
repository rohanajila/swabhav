using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_app.Model
{
    class Library
    {
        private string name;
        private string address;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Library(string name,string address)
        {
            this.name = name;
            this.address = address;
        }

    }
}
