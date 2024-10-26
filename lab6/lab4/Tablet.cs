using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Tablet : Computer
    {
        public double ScreenSize { get; set; }

        public override string ToString() => $"{base.ToString()}, ScreenSize: {ScreenSize}";
    }
}
