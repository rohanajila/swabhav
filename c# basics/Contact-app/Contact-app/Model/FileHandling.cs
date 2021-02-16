using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
    using System.IO;
using System.Threading.Tasks;

namespace Contact_app
{
    class FileHandling
    {
        public void WriteData(Contact obj)
        {
            FileStream fs = new FileStream("d:\\test2.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(obj);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("d:\\test2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
            fs.Close();
        }
        public void ReplaceInFile()
        {
            StreamReader reader = new StreamReader("d:\\test2.txt");
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, " ", "unspecified");

            StreamWriter writer = new StreamWriter("d:\\test.txt");
            writer.Write(content);
            writer.Close();
        }
    }
}
