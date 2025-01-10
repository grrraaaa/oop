using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Device : Product
    {
        public string Brand { get; set; }

        public override string ToString() => $"{base.ToString()}, Brand: {Brand}";
    }
}
