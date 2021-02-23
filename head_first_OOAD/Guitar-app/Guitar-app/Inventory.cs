using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    class Inventory
    {
        private List<Instrument> instruments;
        public List<Instrument> instruments { get => instruments; set => instruments = value; }
        public Inventory()
        {
            instruments = new List<Instrument>();
        }
        public void AddInstrument(string serialNumber,double price,InstrumentSpec spec)
        {
            Instrument instrument = new Instrument(serialNumber, price, spec);
            instruments.Add(instrument);
        }
        public Instrument GetInstrument(String serialNumber)
        {
          
            foreach(Instrument getinstrument in instruments)
            {
                if ((getinstrument.SerialNumber).Equals(serialNumber))
                       return getinstrument;
            }
            return null;
        }
        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for(int i=0;i<guitars.Count;i++)
            {
                GuitarSpec guitarSpec = guitars[i].Spec;
                if(guitarSpec.matches(searchSpec))
                matchingGuitars.Add(guitars[i]);
            }
            return matchingGuitars;
        }
        public List<Mandolin> search(MandolinSpec searchSpec)
        {
            List<Mandolin> matchingMandolins = new List<Mandolin>();
            for (int i = 0; i < mandolins.Count; i++)
            {
                MandolinSpec mandolinSpec = mandolins[i].Spec;
                if (mandolinSpec.matches(searchSpec))
                    matchingMandolins.Add(mandolins[i]);
            }
            return matchingMandolins;
        }
    }
}
