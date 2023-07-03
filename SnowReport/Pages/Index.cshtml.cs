using Microsoft.AspNetCore.Mvc.RazorPages;
using SnowReport.Data;
using SnowReport.Models;
using System.Linq;

namespace SnowReport.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SnowReportContext _context;


        public IndexModel(SnowReportContext context)
        {
            _context = context;
        }


        public void OnGet()
        {

        }
    }
}