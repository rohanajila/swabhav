using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoor_app
{
    class DogDoor
    {
        private Boolean open;
        System.Timers.Timer aTimer = new System.Timers.Timer();
        public DogDoor()
        {
            this.open = false;
        }
        public void Open()
        {
            Console.WriteLine("Dog Door opens.");
            open = true;
            SetTimer();
        }
        public void Close()
        {
            Console.WriteLine("Dog Door closes.");
            open = false;
        }
        public Boolean IsOpen()
        {
            return open;
        }
        public void SetTimer()
        {

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
        }
        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            aTimer.Enabled = false;
            Close();// callActivity();
            aTimer.Elapsed -= new ElapsedEventHandler(OnTimedEvent);
        }
    }
}
