using Microsoft.AspNetCore.Mvc;
using PablosCardLtd.News.Entities;

namespace PablosCarsLtd.Website.ViewComponents
{
    [ViewComponent(Name = "MainPageContent")]
    public class MainPageContentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ICollection<Article> articles)
        {
            return View(articles);
        }
    }
}
