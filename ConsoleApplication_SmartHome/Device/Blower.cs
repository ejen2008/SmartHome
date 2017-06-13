using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    internal class Blower : Device, ISpeedAirable
    {
        public ISpeedSetable SpeedAir { get; set; }

        public Blower(string name, bool state, Speed speedLevel, ISpeedSetable speedAir)
        {
            SpeedAir = speedAir;
            Name = name;
            State = state;
            SpeedAir.SpeedGetSet = speedLevel;

        }

        public Speed LevelSpeed
        {
            get
            {
                return SpeedAir.SpeedGetSet;
            }
            internal set
            {
                SpeedAir.SpeedGetSet = value;
            }
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
            string blowerString = "Вентилятор " + Name + " выкл.";
            string stateBlower = "";

            if (SpeedAir.SpeedGetSet == Speed.Low)
            {
                stateBlower = "низкий";
            }
            else if (SpeedAir.SpeedGetSet == Speed.Medium)
            {
                stateBlower = "средний";
            }
            else if (SpeedAir.SpeedGetSet == Speed.Hight)
            {
                stateBlower = "высокий";
            }
            if (State == true)
            {
                blowerString = "Вентилятор " + Name + " вкл., скорость вращения лопастей " + stateBlower + ".";
            }
            return blowerString;
        }
    }
}
