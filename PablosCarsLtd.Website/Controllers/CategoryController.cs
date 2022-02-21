using Microsoft.AspNetCore.Mvc;
using PablosCardLtd.News.Domain;

namespace PablosCarsLtd.Website.Controllers
{
    public class CategoryController : Controller
    {
        private readonly INewsService _newsService;

        public CategoryController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [Route("category/{categoryId}")]
        public async Task<IActionResult> Index(string categoryId)
        {
            var articles = await _newsService.GetArticlesByCategoryId(categoryId);

            return View(articles);
        }
    }
}
