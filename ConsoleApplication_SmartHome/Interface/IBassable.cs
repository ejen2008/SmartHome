using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    public interface IBassable
    {
        byte BassLevel { get; set; }

        void BassDown();

        void BassUp();
    }
}
