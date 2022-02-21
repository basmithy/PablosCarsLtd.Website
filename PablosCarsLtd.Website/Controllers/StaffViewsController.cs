using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PablosCardLtd.News;
using PablosCardLtd.News.Domain;
using PablosCardLtd.News.Entities;
using PablosCarsLtd.Website.Helpers.EntityMapper;
using PablosCarsLtd.Website.Models.CreateArticleViewModel;

namespace PablosCarsLtd.Website.Controllers
{
    public class StaffViewsController : Controller
    {
        private readonly NewsDbContext _newsDbContext;
        private readonly INewsService _newsService;
        private readonly UserManager<StaffUser> _userManager;
        
        public CreateArticleViewModel CreateArticleViewModel { get; set; } = new();

        public StaffViewsController(NewsDbContext newsDbContext,
            INewsService newsService,
            UserManager<StaffUser> userManager)
        {
            _newsDbContext = newsDbContext;
            _newsService = newsService;
            _userManager = userManager;
        }

        [Route("/create")]
        [Authorize]
        public IActionResult CreateArticle()
        {

            if (ModelState.IsValid)
            {
                var categoryList = _newsDbContext.Categories.ToList().OrderBy(x => x.CategoryName);
                ViewData["Categories"] = new SelectList(categoryList, "CategoryId", "CategoryName");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticleSubmit(CreateArticleViewModel article)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateArticle", article);
            }

            EntityMapper _entityMapper = new(_newsService);

            article.ArticleResultMessage = "Created";

            await _newsService.AddArticle(_entityMapper.MapToArticle(article));
            

            return View("CreateArticleResult", article);

        }
    }
}
