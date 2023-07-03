using System;

public class HomeController : Controller
{
    private readonly SnowReportContext _context;

    public HomeController(SnowReportContext context)
    { 
        _context = context; 
    }

    public IActionResult Index()
    {
        var latestFeedbacks = _context.UserFeedbacks
            .OrderByDescending(x => x.Id)
            .Take(5)
            .ToList();
        viewBag.LatestFeedbacks = latestFeedbacks;

        return View();
    }

    public IActionResult Feedback (FeedbackModel feedbackModel)
    {
        var feedbackRepository = new FeedbackRepository();
        feedbackRepository.Save(feedbackModel);

        return RedirectToAction("Index");
    }

}
