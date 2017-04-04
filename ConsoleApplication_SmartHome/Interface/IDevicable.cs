using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IDevicable
    {
        bool State { get; set; }
        string Name { get; set; }
        event StateDevice stateDevice;
        void On();
        void Off();
    }
}
