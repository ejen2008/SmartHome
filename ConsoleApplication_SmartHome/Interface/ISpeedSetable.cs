using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    internal interface ISpeedSetable
    {
        Speed SpeedGetSet { get; set; }
        void SpeedAirLow();

        void SpeedAirMedium();

        void SpeedAirHight();

    }
}
