using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_app.Model
{
    class College
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
        public College(string name,string address)
        {
            this.name = name;
            this.address = address;
        }

    }
}
