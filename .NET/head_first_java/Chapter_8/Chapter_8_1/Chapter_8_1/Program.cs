using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_1
{
     class Of76: Clowns
    {
        static void Main(string[] args)
        {
            Nose[] i = new Nose[3];
            i[0] = new Acts();
            i[1] = new Clowns();
            i[2] = new Of76();
            for(int x=0;x<3;x++)
            {
                Console.WriteLine(i[x].iMethod()+" "+i[x].GetType().Name );
            }
            Console.ReadKey();
        }
    }
     interface Nose
    {
         int iMethod();

    }
    abstract class Picasso : Nose
    {
        public int iMethod()
        {
            return 7;
        }
    }
    class Clowns: Picasso { }
    class Acts : Picasso
    {
        public int iMethod()
        {
            return 5;
        }
    }
    
}
