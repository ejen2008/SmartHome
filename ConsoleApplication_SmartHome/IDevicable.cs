using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_SmartHome
{
    interface IDevicable
    {
        bool State { get; set; }
        string Name { get; set; }
        void On();
        void Off();
    }
}
