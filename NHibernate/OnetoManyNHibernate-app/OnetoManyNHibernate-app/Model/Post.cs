using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetoManyNHibernate_app.Model
{
    class Post
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual Category Category { get; set; } 
    }
}
