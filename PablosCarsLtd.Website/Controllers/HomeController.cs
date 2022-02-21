using Microsoft.AspNetCore.Mvc;
using PablosCarsLtd.Website.Models;
using System.Diagnostics;
using PablosCardLtd.News.Domain;
using PablosCarsLtd.Website.Models.NewsFeed;

namespace PablosCarsLtd.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsService _newsService;
        public NewsFeedViewModel NewsFeedViewModel { get; set; } = new();

        public HomeController(ILogger<HomeController> logger,
            INewsService newsService)
        {
            _logger = logger;
            _newsService = newsService;
        }

        public async Task<IActionResult> Index()
        {
            NewsFeedViewModel.HeadContent = await _newsService.GetHeadContent();
            NewsFeedViewModel.LatestNews = await _newsService.GetLatestNews(NewsFeedViewModel.HeadContent);
            NewsFeedViewModel.MostViewed = await _newsService.GetMostViewed();

            return View(NewsFeedViewModel);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}