using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_app.Model
{
    class Address
    {
        public virtual int Id { get; set; }
        public virtual string Location { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
