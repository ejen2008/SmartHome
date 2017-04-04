using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    internal class SpeedAir : ISpeedSetable
    {
        private Speed speedLevel;

        public Speed SpeedGetSet
        {
            get
            {
                return speedLevel;
            }
            set
            {
                speedLevel = value;
            }
        }

        public void SpeedAirLow()
        {
            speedLevel = Speed.Low;
        }
        public void SpeedAirMedium()
        {
            speedLevel = Speed.Medium;
        }
        public void SpeedAirHight()
        {
            speedLevel = Speed.Hight;
        }
    }
}
