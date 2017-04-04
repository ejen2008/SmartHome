using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_SmartHome
{
    public interface ITemperaturSetable
    {
        byte Temperature { get; set; }
        void TemperatureUP();
        void TemperatureDown();
    }
}
