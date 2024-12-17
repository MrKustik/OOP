using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ITelevision
    {
        public void OnOff(bool f);

        public void ChoiseChannel(int channel);
    }
}
