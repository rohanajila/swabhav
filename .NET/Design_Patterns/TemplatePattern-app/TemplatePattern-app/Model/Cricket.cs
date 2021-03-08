using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern_app.Model
{
    class Cricket:Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Cricket Game Finished!");
        }
        public override void Initialize()
        {
            Console.WriteLine("Cricket Game Initialized! Start Playing.");
        }
        public override void StartPlay()
        {
            Console.WriteLine("Cricket Game Started. Enjoy the game!");
        }
    }
}
