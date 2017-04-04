using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{

    internal class Conditioner : Device, ITemperaturable, ISpeedAirable
    {
        private Speed levelSpeed;
        protected ITemperaturSetable TemperatureInter { get; set; }
        protected ISpeedSetable SpeedAir { get; set; }

        public Conditioner(string name, bool state, byte temperature, Speed speedLevel, ITemperaturSetable temperatureSet, ISpeedSetable speedAir)
        {
            TemperatureInter = temperatureSet;
            SpeedAir = speedAir;
            Name = name;
            State = state;
            Temperature = temperature;
            SpeedAir.SpeedGetSet = speedLevel;
        }

        public Speed LevelSpeed
        {
            get
            {
                return levelSpeed;
            }
            internal set
            {
                levelSpeed = SpeedAir.SpeedGetSet;
            }
        }

        public byte Temperature
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
        public void TemperatureUp()
        {
            TemperatureInter.TemperatureUP();
        }

        public void TemperatureDown()
        {
            TemperatureInter.TemperatureDown();
        }

        public void SpeedAirLow()
        {
            SpeedAir.SpeedAirLow();
        }
        public void SpeedAirMedium()
        {
            SpeedAir.SpeedAirMedium();
        }
        public void SpeedAirHight()
        {
            SpeedAir.SpeedAirHight();
        }

        public override string ToString()
        {
            string toString = "Кондиционер " + base.ToString();
            string speedString = "";
            if (SpeedAir.SpeedGetSet == Speed.Low)
            {
                speedString = "низкий";
            }
            else if (SpeedAir.SpeedGetSet == Speed.Medium)
            {
                speedString = "средний";
            }
            else if (SpeedAir.SpeedGetSet == Speed.Hight)
            {
                speedString = "высокий";
            }
            if (State == true)
            {
                toString = "Кондиционер " + base.ToString() + ", охлаждает до " + Temperature + " градусов, вентилятор включен на " + speedString + "режим.";

            }
            return toString;
        }
    }
}
