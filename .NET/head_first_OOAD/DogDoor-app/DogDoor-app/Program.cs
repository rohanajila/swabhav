using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DogDoor_app
{
    class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside...");
            recognizer.Recognize("woof");
           // remote.PressButton();
            Console.WriteLine("\nFido has gone outside...");

            Console.WriteLine("\nFido's all done...");
            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException e) { }
            Console.WriteLine("...but he's stuck outside");
            Console.WriteLine("\nFido starts barking...");
            recognizer.Recognize("woof");
            Console.WriteLine("...so Gina grabs the remote control");
           // remote.PressButton();
            Console.WriteLine("\nFido's back inside...");
        

            Console.ReadKey();
        }
    }
}
