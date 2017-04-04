using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public interface IColorRedable
    {
        byte ColorRed { get; set; }
        void ColorRedUp();
        void ColorRedDown();
    }
}
