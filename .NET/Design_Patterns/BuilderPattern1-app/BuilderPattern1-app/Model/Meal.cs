using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1_app.Model
{
    public class Meal
    {
        private List<Iitem> items = new List<Iitem>();

        public void AddItem(Iitem item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach(Iitem item in items)
            {
                cost += item.price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach(Iitem item in items)
            {
                Console.WriteLine("Item: " + item.name());
                Console.WriteLine("Packing: " + item.packing().pack());
                Console.WriteLine("Price: " + item.price());
            }
        }
 
        public void EmptyItems()
        {
            items.Clear();
        }
    }
}
