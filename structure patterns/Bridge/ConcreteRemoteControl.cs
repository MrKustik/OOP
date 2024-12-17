using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ConcreteRemoteControl :RemoteControl
    {
        private int _currentChannel = 1;
        public ConcreteRemoteControl(ITelevision tv) : base(tv) { }

        public override void On()
        {
            _television.OnOff(true);
        }

        public override void Off()
        {
            _television.OnOff(false);
        }

        public override void SetChannel(int channell)
        {
            if (_currentChannel < channell)
            {
                while (_currentChannel != channell)
                {
                    this.Next();
                }
            }
            else
            {
                while (_currentChannel != channell)
                {
                    this.Previous();
                }
            }
        }

        public void Next()
        {
            _currentChannel++;
            base.SetChannel(_currentChannel);
        }

        public void Previous()
        {
            _currentChannel--;
            base.SetChannel(_currentChannel);
        }
    }
}
