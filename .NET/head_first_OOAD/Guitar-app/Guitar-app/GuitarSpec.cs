using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    class GuitarSpec:InstrumentSpec
    {

        private int numStrings;
        public int getNumStrings()
        {
            return numStrings;
        }
        public GuitarSpec(Builder builder, string model, Type type,int numStrings, Wood backWood, Wood topWood):base(builder,model,type,backWood,topWood)
        {
            this.numStrings = numStrings;
        }
        public bool override matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec))
                return false;
            if (!(otherSpec is GuitarSpec))
                return false;
            if (numStrings != otherSpec.numStrings)
                return false;
            return true;
        }
    }
}
