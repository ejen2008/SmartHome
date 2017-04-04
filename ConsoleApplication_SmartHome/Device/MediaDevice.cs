using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal abstract class MediaDevice : Device, IVolumenable, ISwitchable
    {
        public ILevelSetable VolumeSet { get; set; }
        public ISwitchSetable CurrentSet { get; set; }

        public byte Volume
        {
            get
            {
                return VolumeSet.LevelSetup;
            }
            set
            {
                VolumeSet.LevelSetup = value;
            }
        }
        public int Current
        {
            get
            {
                return CurrentSet.Setup;
            }
            set
            {
                CurrentSet.Setup = value;
            }
        }

        public void VolumeUp()
        {
            VolumeSet.LevelUp();
        }
        public void VolumeDown()
        {
            VolumeSet.LevelDown();
        }

        //Методы управления каналами
        public void Next()
        {
            CurrentSet.Next();
        }
        public void Previous()
        {
            CurrentSet.Prev();
        }

        public override string ToString()
        {
            return base.ToString() + ", уровень громкости " + Volume + "%, ";
        }
    }
}
