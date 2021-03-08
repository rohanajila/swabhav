using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderComposite_app.Model
{
    public class File:IStorable
    {
        private string _name;
        private double _size;
        private string _extension;

        public File(string name,double size,string extension)
        {
            _name = name;
            _size = size;
            _extension = extension;
        }

        public string Name { get => _name; }
        public double Size { get => _size; }
        public string Extension { get => _extension; }

        public void display(StringBuilder dashes)
        {
            dashes.Append("\t-" + Name + "." + Extension + "  Size: " + Size + "\n");
        }
    }
}
