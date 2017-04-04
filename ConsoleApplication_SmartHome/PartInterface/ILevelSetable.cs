using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_SmartHome
{
    interface ILevelSetable
    {
        byte LevelSetup { get; set; }
        void LevelUp();
        void LevelDown();
    }
}
