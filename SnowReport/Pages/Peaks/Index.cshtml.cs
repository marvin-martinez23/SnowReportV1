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
    public class IndexModel : PageModel
    {
        private readonly SnowReport.Data.SnowReportContext _context;

        public IndexModel(SnowReport.Data.SnowReportContext context)
        {
            _context = context;
        }

        public IList<SnowTotals> SnowTotals { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.SnowTotals != null)
            {
                SnowTotals = await _context.SnowTotals.ToListAsync();
            }
        }
    }
}
