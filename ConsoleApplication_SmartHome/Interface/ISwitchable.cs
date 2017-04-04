using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public interface ISwitchable
    {
        int Current { get; set; }
        void Next();
        void Previous();
    }
}
