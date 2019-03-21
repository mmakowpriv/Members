using System;
using System.Collections.Generic;

namespace Soka.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime MembershipDate { get; set; }
        //public int OrganizationID { get; set; }
        public Organization Organization { get; set; }
    }
}
