﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_app.Model
{
    interface IStrategy
    {
        int DoOperation(int num1, int num2);
    }
}
