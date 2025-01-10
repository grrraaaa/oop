using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    [Serializable]
    public class Device : Product
    {
        [NonSerialized]
        private string brand;
        [NonSerialized]
        private string sizes;

        public string Brand
        {
            get => brand;
            set => brand = value;
        }

        public override string ToString() => $"{base.ToString()}, Brand: {Brand}";
    }
}
