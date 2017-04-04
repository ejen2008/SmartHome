using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_SmartHome
{
    abstract class ClimatDevice : Device, ITemperaturable
    {

        public abstract byte Temperature { get; set; }

        public abstract void TemperatureUp();

        public abstract void TemperatureDown();
    }
    
}
