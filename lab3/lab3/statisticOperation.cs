using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    using System;
    using System.Linq;

    public static class StatisticOperation
    {
        public static int Sum(Set set)
        {
            return set.CountElements();
        }

        public static int DifferenceMaxMin(Set set)
        {
            if (set.CountElements() == 0) return 0;
            var lengths = set.SortedElements().Select(e => e.Length);
            return lengths.Max() - lengths.Min();
        }

        public static int CountElements(this Set set)
        {
            return set.SortedElements().Count;
        }

        public static int WordCount(this string str)
        {
            return str.Split(new[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int TotalCharacterCount(this Set set)
        {
            return set.SortedElements().Sum(e => e.Length);
        }
    }
}
