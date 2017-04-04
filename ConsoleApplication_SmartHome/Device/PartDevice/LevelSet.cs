using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class LevelSet : ILevelSetable
    {
        private byte levelSet;
        public byte LevelSetup
        {
            get
            {
                return levelSet;
            }
            set
            {
                if (value <= 100)
                {
                    levelSet = value;
                }
            }
        }

        public void LevelUp()
        {
            LevelSetup = Convert.ToByte(LevelSetup + 1);
        }
        public void LevelDown()
        {
            LevelSetup = Convert.ToByte(LevelSetup - 1);
        }
    }
}
