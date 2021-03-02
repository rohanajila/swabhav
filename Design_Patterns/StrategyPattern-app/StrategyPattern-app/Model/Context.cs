using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_app.Model
{
    class Context
    {
        private IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public int ExecuteStrategy(int num1,int num2)
        {
            return _strategy.DoOperation(num1, num2);
        }
    }
}
