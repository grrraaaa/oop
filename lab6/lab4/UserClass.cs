using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class UserClass : BaseClone, ICloneable
    {
        public override bool DoClone() => true;

        bool ICloneable.DoClone()
        {
            return false;
        }
    }
}
