using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public interface IVolumenable
    {
        byte Volume { get; set; }
        void VolumeUp();
        void VolumeDown();
    }
}
