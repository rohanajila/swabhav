using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolderComposite_app.Model;

namespace FolderComposite_app
{
    class Program
    {
        static StringBuilder dashes = new StringBuilder();
        static void Main(string[] args)
        {
            Folder movieFolder = new Folder("movie");
            Folder actionMovieFolder = new Folder("action");
            Folder comedyMovieFolder = new Folder("comedy");
            

            File abcFile = new File("abc", 100, "avi");
            File defFile = new File("def", 150, "mp4");
            File ghiFile = new File("ghi", 150, "avi");
            File jklFile = new File("jkl", 100, "mp4");

            movieFolder.AddChildren(actionMovieFolder);          
            movieFolder.AddChildren(comedyMovieFolder);

            actionMovieFolder.AddChildren(abcFile);
            actionMovieFolder.AddChildren(defFile);
            comedyMovieFolder.AddChildren(ghiFile);
            comedyMovieFolder.AddChildren(jklFile);
            movieFolder.display(dashes);
            Console.WriteLine(dashes.ToString());
            Console.Read();

        }
    }
}
