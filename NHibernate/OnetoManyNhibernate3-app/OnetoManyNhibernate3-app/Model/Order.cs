using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetoManyNhibernate3_app.Model
{
    class Order
    {
        public virtual int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual IList<LineItem> LineItems { get; set; } = new List<LineItem>();

        public virtual void AddLineItem(LineItem item)
        {
            item.Order = this;
            LineItems.Add(item);
        }
    }
}
