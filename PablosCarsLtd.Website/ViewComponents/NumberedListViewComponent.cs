using Microsoft.AspNetCore.Mvc;
using PablosCardLtd.News.Entities;

namespace PablosCarsLtd.Website.ViewComponents
{
    [ViewComponent(Name = "NumberedList")]
    public class NumberedListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ICollection<Article> articles)
        {
            return View(articles);
        }
    }
}
