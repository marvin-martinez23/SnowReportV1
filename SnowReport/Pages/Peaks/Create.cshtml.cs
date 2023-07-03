using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SnowReport.Data;
using SnowReport.Models;

namespace SnowReport.Pages.Addresses
{
    public class CreateModel : PageModel
    {
        private readonly SnowReport.Data.SnowReportContext _context;

        public CreateModel(SnowReport.Data.SnowReportContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SnowTotals SnowTotals { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.SnowTotals == null || SnowTotals == null)
            {
                return Page();
            }

            _context.SnowTotals.Add(SnowTotals);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
