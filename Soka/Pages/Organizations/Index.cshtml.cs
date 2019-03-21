using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Soka.Models;

namespace Soka.Pages.Organizations
{
    public class IndexModel : PageModel
    {
        private readonly Soka.Models.SokaContext _context;

        public IndexModel(Soka.Models.SokaContext context)
        {
            _context = context;
        }

        public IList<Organization> Organization { get;set; }

        public async Task OnGetAsync()
        {
            Organization = await _context.Organization.ToListAsync();
        }
    }
}
