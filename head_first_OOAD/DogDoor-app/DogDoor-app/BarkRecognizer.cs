using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor_app
{
    class BarkRecognizer
    {
        private DogDoor door;
        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }
        public void Recognize(string bark)
        {
            Console.WriteLine("Bark Recognizer: Heard a " + bark);
            door.Open();
        }

    }
}
