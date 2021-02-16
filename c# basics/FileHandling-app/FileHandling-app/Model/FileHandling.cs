using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileHandling_app
{
    class FileHandling
    {
        public void WriteData()
        {
            FileStream fs = new FileStream("d:\\test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text which you want to write to the file");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("d:\\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Content of test file");
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
            StreamReader reader = new StreamReader("d:\\test.txt");
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, " ", "unspecified");

            StreamWriter writer = new StreamWriter("d:\\test.txt");
            writer.Write(content);
            writer.Close();
        }
    }
}
