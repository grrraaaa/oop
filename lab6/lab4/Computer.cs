﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Computer : Device
    {
        public string Processor { get; set; }

        public override string ToString() => $"{base.ToString()}, Processor: {Processor}";
    }
}
