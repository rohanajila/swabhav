﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetoManyNhibernate3_app.Model
{
    class LineItem
    {
        public virtual int Id { get; set; }

        public virtual int Quantity { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product ProductType { get; set; }

        public virtual void CreateLineItem(Product product)
        {
            product.lineItems.Add(this);
            ProductType = product;
        }
    }
}
