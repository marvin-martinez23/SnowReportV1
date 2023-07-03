using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SnowReport.Data;
using SnowReport.Models;

namespace SnowReport.Pages.Addresses
{
    public class EditModel : PageModel
    {
        private readonly SnowReport.Data.SnowReportContext _context;

        public EditModel(SnowReport.Data.SnowReportContext context)
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

            var snowtotals =  await _context.SnowTotals.FirstOrDefaultAsync(m => m.ID == id);
            if (snowtotals == null)
            {
                return NotFound();
            }
            SnowTotals = snowtotals;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SnowTotals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SnowTotalsExists(SnowTotals.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SnowTotalsExists(int id)
        {
          return (_context.SnowTotals?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
