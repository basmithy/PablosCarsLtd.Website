using Microsoft.AspNetCore.Mvc;
using PablosCardLtd.News.Domain;
using PablosCarsLtd.Website.Models.ArticleViewModel;

namespace PablosCarsLtd.Website.Controllers
{
    public class ArticleController : Controller
    {
        private readonly INewsService _newsService;

        public ArticleController(INewsService newsService)
        {
            _newsService = newsService;
        }

        private ArticleViewModel ArticleViewModel { get; set; } = new();

        [Route("article/{articleId}")]
        public async Task<IActionResult> Index(string articleId)
        {
            ArticleViewModel.Article = await _newsService.GetSingleArticleById(articleId);
            ArticleViewModel.RelatedArticles = await _newsService.GetRelatedArticles(ArticleViewModel.Article);

            await _newsService.IncreaseViewCount(articleId);

            return View("Index", ArticleViewModel);
        }
    }
}
