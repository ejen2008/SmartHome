using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_SmartHome
{
    class Heater : ClimatDevice
    {
        protected ITemperaturSetable TemperatureInter { get; set; }

        public Heater(string name, bool state, byte temperature, ITemperaturSetable temperatureSet)
        {
            TemperatureInter = temperatureSet;
            Name = name;
            State = state;
            Temperature = temperature;
        }

        public override byte Temperature
        {
            get
            {
                return TemperatureInter.Temperature;
            }
            set
            {
                TemperatureInter.Temperature = value;
            }
        }

        public override void TemperatureUp()
        {
            TemperatureInter.TemperatureUP();
        }

        public override void TemperatureDown()
        {
            TemperatureInter.TemperatureDown();
        }

        public override string ToString()
        {
            string toString = "Отопление " + base.ToString();
            if (State == true)
            {
                toString = "Отопление " + base.ToString() + ", нагревает до " + Temperature + " градусов.";
            }
            return toString;
        }
    }
}
