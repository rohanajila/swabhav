using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_solution_app.Model
{
    class TaxCalculation
    {
        private ILogger _log;
        public TaxCalculation(ILogger log)
        {
            _log = log;
        }
        public ILogger getLog()
        {
            return _log;
        }
        public int Calculate(int amount, int rate)
        {
            try
            {
                int r = amount / rate;
                return r;
            }
            catch (Exception e)
            {
                if (this.getLog() is TxtLogger)
                {
                    TxtLogger txtF = new TxtLogger();
                    txtF.Log(e.Message);
                    return -1;
                }
                else
                {
                    XmlLogger xm = new XmlLogger();
                    xm.Log(e.Message);
                    return -1;
                }

            }
        }
    }
}
