using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework2_app.Model
{
    class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Customer CustNo { get; set; }
    }
}
