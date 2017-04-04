using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    internal interface ITemperaturSetable
    {
        byte Temperature { get; set; }
        void TemperatureUP();
        void TemperatureDown();
    }
}
