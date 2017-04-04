using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal abstract class Device : IDevicable
    {
        
        public bool State { get; set; }
        public string Name { get; set; }
        public event StateDevice stateDevice;

        public virtual void On()
        {
            State = true;
            if (stateDevice != null)
            {
                stateDevice.Invoke();
            }
        }
        public void Off()
        {
            State = false;
        }


        public override string ToString()
        {
            string stateToString;
            if (State == true)
            {
                stateToString = Name + " вкл.";
            }
            else
            {
                stateToString = Name + " выкл.";
            }
            return stateToString;
        }
    }
}
