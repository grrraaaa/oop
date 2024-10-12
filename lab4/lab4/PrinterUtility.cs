using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class PrinterUtility
    {
        public void IAmPrinting(Product someObj)
        {
            Console.WriteLine("IAmPrinting: " + someObj.ToString());
        }
    }
}
