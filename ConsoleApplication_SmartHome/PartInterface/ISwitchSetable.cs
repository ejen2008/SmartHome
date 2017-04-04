using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_SmartHome
{
    interface ISwitchSetable
    {
        int Setup { get; set; }
        void Next();
        void Prev();

    }
}
