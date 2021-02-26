using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_violation_app.Model
{
    class TaxCalculation
    {
        private LogType _log;
        public TaxCalculation(LogType log)
        {
            _log = log;
        }
        public LogType getLog()
        {
            return _log;
        }
        public int Calculate(int amount,int rate)
        {
            try
            {
                int r = amount / rate;
                return r;
            }catch(Exception e)
            {
                if(this.getLog()==LogType.TXT)
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
