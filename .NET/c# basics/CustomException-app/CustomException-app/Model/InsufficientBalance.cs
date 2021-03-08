using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException_app
{
    class InsufficientBalance:Exception
    {
        public InsufficientBalance(string message) : base(message)
        {
        }
    }
}
