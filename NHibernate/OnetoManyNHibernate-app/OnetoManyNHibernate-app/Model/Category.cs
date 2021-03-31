using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetoManyNHibernate_app.Model
{
    class Category
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Post> Post { get; set; }
        
        public Category()
        {
            Post = new List<Post>();
        }
        
    }
}
