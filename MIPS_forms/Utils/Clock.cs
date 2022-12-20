using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPS_forms.Utils
{
    class Clock
    {
        public int Value;

        public Clock() { Value = 0; }
        public void Increase()
        {
            Value++;
        }
        public int Get() { return Value; }

        public static implicit operator Clock(Microsoft.VisualBasic.Devices.Clock v)
        {
            throw new NotImplementedException();
        }
    }
}
