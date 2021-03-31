using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo_app
{
    public static class StringExtensions
    {
        public static string ToSnakeCase(this string a)
        {
            int n = a.Length;
            string s = "";
            for(int i=0;i<n;i++)
            {
                if (a[i].Equals(' '))
                    s = s + '_';
                else
                    s = s + a[i];
            }
            return s;
        }
    }
}
