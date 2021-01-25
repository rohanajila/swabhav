using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2_1
{
    class DrumKitTestDrive
    {
        static void Main(string[] args)
        {
            DrumKit d = new DrumKit();
            d.playSnare();
            d.snare = false;
            d.playTopHat();
            if (d.snare == true)
                d.playSnare();
            Console.ReadLine();
        }
    }
    class DrumKit
    {
        public
        Boolean topHat = true;
        public
        Boolean snare = true;
        public void playSnare()
        {
            Console.WriteLine("bang bang ba-bang");
        }
        public void playTopHat()
        {
            Console.WriteLine("ding ding da-ding");
        }

    }
}
