using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract partial class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => $"Product: {Name}, Price: {Price}";
    }
}
