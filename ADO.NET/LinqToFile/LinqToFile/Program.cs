using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Windows\System32";

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(folderPath);

            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);

            var fileList1 = fileList.OrderBy(x => x.FullName).Take(3);
            foreach(System.IO.FileInfo fileInfo in fileList1)
            {
                Console.WriteLine("Full Name: " + fileInfo.FullName + " Size:" + fileInfo.Length);
            }
            Console.WriteLine("Biggest File:");
            var biggestFile = fileList.OrderByDescending(x => x.Length).Take(1);
            foreach (System.IO.FileInfo fileInfo in biggestFile)
            {
                Console.WriteLine("Full Name: "+fileInfo.FullName+" Size:"+fileInfo.Length);
            }
            Console.ReadKey();
        }
    }
}
