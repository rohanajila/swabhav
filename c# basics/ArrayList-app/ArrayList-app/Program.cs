using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_app
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add("Kill");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            foreach (var item in arlist1)
                Console.Write(item + ", ");
            arlist1.Remove(null); 
            arlist1.RemoveAt(4); 
            arlist1.RemoveRange(0, 2);
            Console.WriteLine("\n\n");
           for (int i = 0; i < arlist1.Count; i++)
                Console.Write(arlist1[i] + ", ");
            int j = arlist1.IndexOf("Kill");
            if(j!=-1)
            {
                arlist1[j] = "dont kill";
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < arlist1.Count; i++)
                Console.Write(arlist1[i] + ", ");
            Console.ReadKey();

        }
    }
}
