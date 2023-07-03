using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SnowReport.Data;
using SnowReport.Models;

namespace SnowReport.Pages.Addresses
{
    public class DetailsModel : PageModel
    {
        private readonly SnowReport.Data.SnowReportContext _context;

        public DetailsModel(SnowReport.Data.SnowReportContext context)
        {
            _context = context;
        }

      public SnowTotals SnowTotals { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            SnowTotals = await _context.SnowTotals
                        .Include(s => s.Feedbacks)
                        .FirstOrDefaultAsync(m => m.ID == id);

            if (SnowTotals == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
