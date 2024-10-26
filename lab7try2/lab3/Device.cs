using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Device
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{Type}: {Name}";
        }
    }
}
