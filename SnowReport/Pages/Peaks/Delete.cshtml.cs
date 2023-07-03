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
    public class DeleteModel : PageModel
    {
        private readonly SnowReport.Data.SnowReportContext _context;

        public DeleteModel(SnowReport.Data.SnowReportContext context)
        {
            _context = context;
        }

        [BindProperty]
      public SnowTotals SnowTotals { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SnowTotals == null)
            {
                return NotFound();
            }

            var snowtotals = await _context.SnowTotals.FirstOrDefaultAsync(m => m.ID == id);

            if (snowtotals == null)
            {
                return NotFound();
            }
            else 
            {
                SnowTotals = snowtotals;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.SnowTotals == null)
            {
                return NotFound();
            }
            var snowtotals = await _context.SnowTotals.FindAsync(id);

            if (snowtotals != null)
            {
                SnowTotals = snowtotals;
                _context.SnowTotals.Remove(SnowTotals);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
