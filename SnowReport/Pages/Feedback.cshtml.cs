using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SnowReport.Data;
using SnowReport.Models;

namespace SnowReport.Pages
{
    public class FeedbackModel : PageModel
    {
        private readonly SnowReportContext _context;

        public FeedbackModel (SnowReportContext context)
        {
            _context = context;
        }
        [BindProperty]
        public UserFeedback UserFeedback { get; set; }
  
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _context.UserFeedbacks.Add(UserFeedback);
            _context.SaveChanges();

            return RedirectToPage("./Feedback");

        }
    }
}
