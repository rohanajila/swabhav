using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_app_Phase2.Model
{
    public class OutOfCellException:Exception
    {
        public OutOfCellException() : base("Cell number entered is out of range")
        {

        }
    }
}
