using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class SampleClassA
    {
        public SampleClassA() { }
        public SampleClassA(int value) { }

        public void Method1() { }
        public int Method2(string input) => input.Length;

        public int PropertyA { get; set; }
    }

    public class SampleClassB
    {
        public SampleClassB() { }

        public void Method3(double value) { }
        public string Method4(int a, int b) => (a + b).ToString();
    }
}
