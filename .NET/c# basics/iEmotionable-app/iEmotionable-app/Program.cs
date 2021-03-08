using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEmotionable_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Boy obj1 = new Boy();
            Man obj2 = new Man();
            PrintInfo(obj1);
            PrintInfo(obj2);
            Console.ReadKey();

        }
        public static void PrintInfo()
        {
           if(obj is Man)
            {
                Man mobj = (Man)obj;
                mobj.Depart();
                mobj.Wish();
                mobj.Cry();
                mobj.Laugh();
            }
           else if (obj is Boy)
            {
                Boy bobj = (Boy)obj;
                bobj.Cry();
                bobj.Laugh();
            }
        }
    }
}
