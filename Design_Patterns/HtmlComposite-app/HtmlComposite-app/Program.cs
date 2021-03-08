using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlComposite_app.Model;
using System.IO;

namespace HtmlComposite_app
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlGroup html = new ControlGroup("html");
            ControlGroup body = new ControlGroup("body");
            ControlGroup div = new ControlGroup("div");

            html.AddControl(body);
            body.AddControl(div);

            div.AddControl(new Control("input", "text", "username"));
            div.AddControl(new Control("br"));

            StringBuilder sb = html.parseHtml();
            WriteCode(sb);
            CreateHtmlFile(sb);
            Console.Read();
        }
        private static void CreateHtmlFile(StringBuilder sb)
        {
            FileStream fs = new FileStream("d:\\testfile.html", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {                               
                sw.WriteLine(sb);               
            }
            catch(FileNotFoundException e)
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
        private static void WriteCode(StringBuilder sb)
        {
            Console.WriteLine(sb.ToString());
        }
    }
}
