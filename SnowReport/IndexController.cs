using Microsoft.AspNetCore.Mvc;
using SnowReport.Models;

namespace SnowReport
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            var snowTotals = SnowTotals.GetAll();
            
            ViewBag.SnowTotals = snowTotals ?? new List<SnowTotals>();
            
            return View();
        }
    }
}
