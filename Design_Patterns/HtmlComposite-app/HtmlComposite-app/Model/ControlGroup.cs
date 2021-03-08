using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlComposite_app.Model
{
    public class ControlGroup:IHtml
    {
        private string _tag;

        public List<IHtml> controls = new List<IHtml>();

        public StringBuilder controlGroup = new StringBuilder();

        public ControlGroup(string tag)
        {
            _tag = tag;
        }

        public void AddControl(IHtml element)
        {
            controls.Add(element);
        }

        public StringBuilder parseHtml()
        {
            controlGroup.Append("<" + _tag + ">\n");
            if(controls!=null)
            {
                foreach(IHtml ihtmlElement in controls)
                {
                    controlGroup.Append(ihtmlElement.parseHtml());
                }
            }
            controlGroup.Append("</" + _tag + ">\n");
            return controlGroup;
        }
        public override string ToString()
        {
            return controlGroup.ToString();
        }

    }
}
