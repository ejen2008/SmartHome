using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public class Factory
    {
        public IDevicable[] CreatorDevice()
        {
            IDevicable[] myDevice = new Device[]
            {
                new TV("Samsung", false, 115, 1, 45, new LevelSet(), new SwitcSet(), new LevelSet()),
                new Sound("MyIPod", false, 45, 5, new LevelSet(), new SwitcSet(), new LevelSet()),
                new Conditioner("Panas", false, 25, Speed.Hight, new TemperatureSetting(), new SpeedAir()),
                new Heater ("my Hot Heater", false, 26, new TemperatureSetting()),
                new Blower ("Oriston", false, Speed.Low, new SpeedAir())
            };

            myDevice[2].stateDevice += myDevice[3].Off;
            myDevice[3].stateDevice += myDevice[2].Off;
            return myDevice;
        }
        public IDevicable CreatorTV(string name)
        {
            return new TV(name, false, 15, 1, 35, new LevelSet(), new SwitcSet(), new LevelSet());
        }

        public IDevicable CreatorSound(string name)
        {
            return new Sound(name, false, 45, 1, new LevelSet(), new SwitcSet(), new LevelSet());
        }

        public IDevicable CreatorConditioner(string name)
        {
            return new Conditioner(name, false, 26, Speed.Low, new TemperatureSetting(), new SpeedAir());
        }

        public IDevicable CreatorHeater(string name)
        {
            return new Heater(name, false, 27, new TemperatureSetting());
        }

        public IDevicable CreatorBlower(string name)
        {
            return new Blower(name, false, Speed.Hight, new SpeedAir());
        }
    }
}
