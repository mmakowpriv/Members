using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soka.Models
{
    public static class DBInitializer
    {
        public static void Initialize(SokaContext context)
        {
            if (context.Member.Any()) { return; }

            var west = new Organization { Type = OrganizationType.Group, Name = "West" };
            context.Organization.Add(west);
            //context.SaveChanges();

            context.Member.AddRange(
                new Member { FirstName = "Tomasz", LastName = "Jarocki", MembershipDate = DateTime.Today, Organization = west },
                new Member { FirstName = "Jan", LastName = "Lisecki", MembershipDate = DateTime.Today.AddYears(-1), Organization = west },
                new Member { FirstName = "Joanna", LastName = "Rasto", MembershipDate = DateTime.Today.AddMonths(-4), Organization = west }
                );
            context.SaveChanges();
        }

    }
}
