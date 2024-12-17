using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class SonyTelevision : ITelevision
    {
        private int _Channel = 1;
        public void OnOff(bool f)
        {
            if (f)
            {
                Console.WriteLine("Sony is on");
            }
            else
            {
                Console.WriteLine("Sony is off");
            }
        }
        public void ChoiseChannel(int channel)
        {
            _Channel = channel;
            Console.WriteLine($"Switched to {_Channel} channel");
        }
    }
}
