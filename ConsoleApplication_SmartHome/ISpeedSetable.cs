using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_SmartHome
{
    public interface ISpeedSetable
    {
        Speed SpeedGetSet { get; set; }
        void SpeedAirLow();

        void SpeedAirMedium();

        void SpeedAirHight();

    }
}
