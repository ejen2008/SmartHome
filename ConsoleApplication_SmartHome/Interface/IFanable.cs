using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface ISpeedAirable
    {
        Speed LevelSpeed { get; }
        void SpeedAirLow();

        void SpeedAirMedium();

        void SpeedAirHight();

    }
}
