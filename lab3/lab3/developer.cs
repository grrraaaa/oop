using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public partial class Set
    {
        public class Developer
        {

            public string FullName { get; set; }
            public int Id { get; set; }
            public string Department { get; set; }

            public Developer(string fullName, int id, string department)
            {
                FullName = fullName;
                Id = id;
                Department = department;
            }
        }
    }
}
