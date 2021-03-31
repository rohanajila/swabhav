using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EmployeeAddressEF_app.Model
{
    class Address
    {
        [Key]
        public int Aid { get; set; }
        public string Addrs { get; set; }
        public virtual Employee Eid { get; set; } 
    }
}
