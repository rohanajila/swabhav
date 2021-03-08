using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    class MandolinSpec :InstrumentSpec
    {
        private Style style;
        public Style GetStyle()
        {
            return style;
        }
        public MandolinSpec(Builder builder, string model, Type type,Style style, Wood backWood, Wood topWood):base(builder,model,type,backWood,topWood)
        {
            this.style = style;
        }
        public bool matches(MandolinSpec otherSpec)
        {
            if (!base.matches(otherSpec))
                return false;
            if (!(otherSpec is MandolinSpec))
                return false;
            if (style != otherSpec.style)
                return false;
            return true;
        }
    }
}
