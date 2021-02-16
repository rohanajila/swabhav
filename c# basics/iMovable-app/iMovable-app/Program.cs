using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMovable_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Movable[] MovableVehicles = { new Car(), new Bike(), new Truck() };
            PrintInfo(MovableVehicles);
            Console.Read();
            
        }
        public static void PrintInfo(Movable[] MovableVehicles)
        {
           foreach(Movable vehicles in MovableVehicles)
            {
                vehicles.Run();
            }
        }
    }
}
