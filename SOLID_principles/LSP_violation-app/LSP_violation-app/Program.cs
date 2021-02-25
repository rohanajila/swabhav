using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSP_violation_app.Model;

namespace LSP_violation_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(30,20);
            Console.WriteLine(Should_not_change_length_if_breadth_changes(r1));
            Square s1 = new Square(30);
            Console.WriteLine(Should_not_change_length_if_breadth_changes(s1));
            Console.Read();
            
        }
        public static bool Should_not_change_length_if_breadth_changes(Rectangle obj)
        {
            int before = obj.Length;
            obj.Breadth = obj.Length + 10;
            int after = obj.Breadth;
            if(before==after)
            {
                return true;
            }
            return false;
        }
    }
}
