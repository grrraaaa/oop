using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Scanner : Device
    {
        public int Resolution { get; set; }

        public override string ToString() => $"{base.ToString()}, Resolution: {Resolution}";
    }
}
