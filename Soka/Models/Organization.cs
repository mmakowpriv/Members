using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soka.Models
{
    public enum OrganizationType { Group, District, Chapter, HeadQuarter }

    public class Organization
    {
        public int ID { get; set; }
        
        public OrganizationType Type { get; set; }
        //public int ParentID { get; set; }

        //public Organization Parent { get; set; }

        public ICollection<Member> Members { get; set; }

        public string Name { get; set; }
    }
}
