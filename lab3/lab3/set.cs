using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3
{

    public partial class Set
    {
        private HashSet<string> elements;

        public Set()
        {
            elements = new HashSet<string>();
            ProductionInfo = new Production(0, "Default");
        }

        public void Add(string item)
        {
            elements.Add(item);
        }

        public void Remove(string item)
        {
            elements.Remove(item);
        }

        public bool Contains(string item)
        {
            return elements.Contains(item);
        }

        public static Set operator <<(Set set, string item)
        {
            set.Add(item);
            return set;
        }

        public static Set operator >>(Set set, string item)
        {
            set.Remove(item);
            return set;
        }

        public static bool operator <(Set setA, Set setB)
        {
            return setA.elements.IsSubsetOf(setB.elements);
        }

        public static bool operator >(Set setA, Set setB)
        {
            return setA.elements.IsSupersetOf(setB.elements);
        }

        public static bool operator ==(Set setA, Set setB)
        {
            return setA.elements.SetEquals(setB.elements);
        }

        public static bool operator !=(Set setA, Set setB)
        {
            return !setA.elements.SetEquals(setB.elements);
        }

        public static Set operator &(Set setA, Set setB)
        {
            var intersection = new Set();
            foreach (var element in setA.elements.Intersect(setB.elements))
            {
                intersection.Add(element);
            }
            return intersection;
        }

        public string ShortestWord()
        {
            return elements.Where(word => !string.IsNullOrEmpty(word))
                           .OrderBy(word => word.Length)
                           .FirstOrDefault() ?? string.Empty;
        }

        public List<string> SortedElements()
        {
            return elements.ToList().OrderBy(e => e).ToList();
        }

        public override string ToString()
        {
            return "{" + string.Join(", ", elements) + "}";
        }

        public Production ProductionInfo { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Set set && this == set;
        }

        public override int GetHashCode()
        {
            return elements != null ? elements.GetHashCode() : 0;
        }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= elements.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                }

                return elements.ElementAt(index);
            }


        }
        public void getProd()
        {
            Console.WriteLine(this.ProductionInfo.Id);
        }
    }
}
