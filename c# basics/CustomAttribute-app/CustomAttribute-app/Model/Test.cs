using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomAttribute_app
{
    [AttributeUsage(AttributeTargets.All)]
    class Test:Attribute
    {
        
     }
}
