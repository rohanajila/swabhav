using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    abstract class InstrumentSpec
    {
        private Builder builder;
        private string model;
        private Type type;
        private Wood backWood;
        private Wood topWood;
       
        public Builder getBuilder()
        {
            return builder;
        }
        public string getModel()
        {
            return model;
        }
        public Type getType()
        {
            return type;
        }
        public Wood getBackWood()
        {
            return backWood;
        }
        public Wood getTopWood()
        {
            return topWood;
        }
        public string Model { get => model; }
       
        public InstrumentSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }
        public bool virtual matches(InstrumentSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;
            string model = otherSpec.Model.ToLower();
            if ((model != null) && (!model.Equals("")) && (!model.Equals(Model.ToLower())))
                return false;
            if (otherSpec.type != type)
                return false;
            if (otherSpec.topWood != topWood)
                return false;
            if (otherSpec.backWood != backWood)
                return false;
            return true;
        }
    }
}
