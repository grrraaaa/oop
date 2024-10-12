using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class BaseClone : ICloneable
    {
        public abstract bool DoClone();
    }
}
