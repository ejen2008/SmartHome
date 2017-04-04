using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_SmartHome
{
    public class TemperatureSetting : ITemperaturSetable
    {
        private byte temperature;
        public byte Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value > 18 && value <= 30)
                {
                    temperature = value;
                }
            }
        }
        public void TemperatureDown()
        {
            Temperature = Convert.ToByte(Temperature-1);
        }
        public void TemperatureUP()
        {
            Temperature = Convert.ToByte(Temperature + 1);
        }
    }
}
