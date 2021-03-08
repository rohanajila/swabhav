using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern_app.Model
{
    class Football:Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Football Game Finished!");
        }
        public override void Initialize()
        {
            Console.WriteLine("Football Game Initialized! Start Playing.");
        }
        public override void StartPlay()
        {
            Console.WriteLine("Football Game Started. Enjoy the game!");
        }
    }
}
