using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework2_app.Model
{
    [Table("Customer")]
    class Customer
    {
        [Key]
        public int CustNo { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public virtual List<Order> CustOrders { get; }
        public Customer()
        {
            CustOrders = new List<Order>();
        }
    }
}
