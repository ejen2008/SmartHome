using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_SmartHome
{
    public interface ITemperaturable
    {
        byte Temperature { get; set; }

        void TemperatureDown();

        void TemperatureUp();
    }
}
