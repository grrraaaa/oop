using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public partial class Set
    {
        public class Production
        {
            public int Id { get; set; }
            public string OrganizationName { get; set; }

            public Production(int id, string organizationName)
            {
                Id = id;
                OrganizationName = organizationName;
            }
        }
    }
}
