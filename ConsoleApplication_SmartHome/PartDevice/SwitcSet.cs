using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_SmartHome
{
    class SwitcSet : ISwitchSetable
    {
        private int current;
        public int Setup
        {
            get
            {
                return current;
            }
            set
            {
                if (value >= 0)
                {
                    current = value;
                }
            }
        }
        public void Next()
        {
            Setup = Setup + 1;
        }
        public void Prev()
        {
            Setup = Setup - 1;
        }
    }
}
