using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SnowReport.Models;
using System.Collections.Generic;

namespace SnowReport.Pages
{
    public class HomeModel : PageModel
    {

        public List<SnowTotals> SnowTotals { get; set; }

        public void OnGet()
        {
            {
                _ = new SnowTotals { MountainName = "Mountain A", NewSnow = 10 };
                _ = new SnowTotals { MountainName = "Mountain B", NewSnow = 5 };
                _ = new SnowTotals { MountainName = "Mountain C", NewSnow = 20 };
            }
        }
    }
}
