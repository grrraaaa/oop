using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    sealed class SealedPrinter : Printer
    {
        public DeviceInfo Info { get; internal set; }

        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => $"SealedPrinter: {base.ToString()}";
        public override void Print() => Console.WriteLine("Sealed Printer is printing...");
    }
}
