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
    public class DetailsModel : PageModel
    {
        private readonly Soka.Models.SokaContext _context;

        public DetailsModel(Soka.Models.SokaContext context)
        {
            _context = context;
        }

        public Organization Organization { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Organization = await _context.Organization.FirstOrDefaultAsync(m => m.ID == id);

            if (Organization == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
