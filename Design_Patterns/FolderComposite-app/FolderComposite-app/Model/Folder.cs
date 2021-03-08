using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderComposite_app.Model
{
    public class Folder: IStorable
    {
        private string _name;
        private static string dash = "-";
        private List<IStorable> children = new List<IStorable>();
        static int count = 0;

        public Folder(string name)
        {
            _name = name;
        }

        public string Name { get => _name; }

        public void AddChildren(IStorable storable)
        {
            children.Add(storable);
            
        }

        public void display(StringBuilder dashes)
        {
            if (count == 0)
            {
                dashes.Append(dash + dash + dash + _name + "\n");
                count++;
            }

            if (count != 0)
            {
                dashes.Append("  " + dash + dash + _name + "\n");
            }
               
            if (children!=null)
            {
                foreach(IStorable storable in children)
                {
                    
                    storable.display(dashes);
                    
                }
            }
            
        }
    }
}
