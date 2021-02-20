using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    class Inventory
    {
        private List<Guitar> guitars;
        public Inventory()
        {
            guitars = new List<Guitar>();
        }
        public void AddGuitar(string serialNumber,double price,GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }
        public Guitar GetGuitar(String serialNumber)
        {
          
            foreach(Guitar getguitar in guitars)
            {
                if ((getguitar.SerialNumber).Equals(serialNumber))
                       return getguitar;
            }
            return null;
        }
        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for(int i=0;i<matchingGuitars.Count;i++)
            {
                if(guitars.)
                {

                }
            }
        }
    }
}
