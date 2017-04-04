using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    internal class Sound : MediaDevice, IBassable
    {
        private ILevelSetable bassLevel;

        public Sound(string name, bool state, byte volume, int track, ILevelSetable volumeSet, ISwitchSetable trackSet, ILevelSetable bass, byte levelBass = 45)
        {
            this.VolumeSet = volumeSet;
            this.CurrentSet = trackSet;
            this.bassLevel = bass;
            Name = name;
            State = state;
            Current = track;
            BassLevel = levelBass;
        }

        public byte BassLevel
        {
            get
            {
                return bassLevel.LevelSetup;
            }
            set
            {
                bassLevel.LevelSetup = value;
            }
        }

        public void BassDown()
        {
            bassLevel.LevelDown();
        }

        public void BassUp()
        {
            bassLevel.LevelUp();
        }

        public override string ToString()
        {

            string toString;
            if (State == true)
            {
                toString = "Муз. проигрыватель " + base.ToString() + "текущий трек " + Current + ", уровень баса " + BassLevel + "%";
            }
            else
            {
                toString = "Муз. проигрыватель " + Name + " выкл.";
            }
            return toString;
            //return "Муз. проигрыватель " + base.ToString() + "текущий трек " + Current + ", уровень баса " + BassLevel + "%";
        }
    }
}
