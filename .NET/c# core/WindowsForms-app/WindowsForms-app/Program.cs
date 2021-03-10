using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms_app
{
    class Program
    {       
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();           
            Case1();
            Case2();
            Case3();
            Console.Read();
        }

        public static void Case1()
        {
            WelcomeForm form = new WelcomeForm();
            form.Load += Log;
            Application.Run(form);

        }
        public static void Case2()
        {
            WelcomeForm form = new WelcomeForm();
            form.Load += delegate (object sender, EventArgs args)
            {
                  Console.WriteLine("Inside anonymous function\nWriting to file");
                  FileStream fs = new FileStream("c:\\swabhav\\.NET\\c# core\\WindowsForms-app\\testfile1.txt", FileMode.Append, FileAccess.Write);
                  StreamWriter sw = new StreamWriter(fs);
                  try
                  {
                      sw.WriteLine("Form loaded");
                  }
                  catch (FileNotFoundException e)
                  {
                      Console.WriteLine(e.Message);
                  }
                  finally
                  {
                      sw.Flush();
                      sw.Close();
                      fs.Close();
                  }
            };
            Application.Run(form);
        }
        public static void Case3()
        {
            WelcomeForm form = new WelcomeForm();
            form.Load += (sender, args) =>
            {
                Console.WriteLine("Inside lambda function\nWriting to file");
                FileStream fs = new FileStream("c:\\swabhav\\.NET\\c# core\\WindowsForms-app\\testfile1.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                try
                {
                    sw.WriteLine("Form loaded");
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            };
            Application.Run(form);
        }
        public static void Log(object sender,EventArgs args)
        {
            
            Console.WriteLine("Inside named function\nWriting to file");            
            FileStream fs = new FileStream("c:\\swabhav\\.NET\\c# core\\WindowsForms-app\\testfile1.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                sw.WriteLine("Form loaded");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
    }
}
