using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Soka.Models
{
    public class SokaContext : DbContext
    {
        public SokaContext (DbContextOptions<SokaContext> options)
            : base(options)
        {
        }

        public DbSet<Soka.Models.Member> Member { get; set; }
    }
}
