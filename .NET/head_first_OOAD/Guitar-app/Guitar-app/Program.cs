using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddGuitar("123",15000, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC,12, Wood.ALDER, Wood.ALDER));
            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC,12, Wood.ALDER, Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars.Count != 0)
            {
                Console.WriteLine("Erin, yoou might like these guitars: ");
                for (int i = 0; i < matchingGuitars.Count; i++)
                {
                    GuitarSpec spec = matchingGuitars[i].Spec;
                    Console.WriteLine("We have a " + spec.getBuilder() + " " + spec.getModel() + " " + spec.getType() + " guitar:\n        " + spec.getBackWood() + " back and sides,\n      " + spec.getTopWood() + " top.\n");
                    Console.WriteLine("You can have it for only $" + matchingGuitars[i].Price);
                }
            }
            else
                Console.WriteLine("Sorry, Erin, we have nothing for you.");

            Console.Read();
        }
    }
    public enum Type
    {
        ACOUSTIC, ELECTRIC

    }
    public enum Builder
    {
        FENDER, MARTIN, GIBSON, COLLINGS, OLSON, RYAN, PRS, ANY
    }
    public enum Wood
    {
        INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY, MAPLE, COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA
    }
    public enum Style
    {
        A,F
    }

}
