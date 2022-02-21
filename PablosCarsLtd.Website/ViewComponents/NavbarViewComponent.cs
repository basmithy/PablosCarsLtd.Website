using Microsoft.AspNetCore.Mvc;
using PablosCardLtd.News.Domain;
using PablosCarsLtd.Website.Models.Navbar;

namespace PablosCarsLtd.Website.ViewComponents
{
    [ViewComponent(Name = "Navbar")]
    public class NavbarViewComponent : ViewComponent
    {
        private NavbarViewModel navbarViewModel { get; set; } = new();
        private INewsService _newsService;

        public NavbarViewComponent(INewsService newsService)
        {
            _newsService = newsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var today = DateTime.Now.Hour;
            var greeting = "";
            if(today is >= 0 and < 12)
            {
                greeting = "Good Morning";
            }
            if (today is >= 12 and < 18)
            {
                greeting = "Good Afternoon";
            }
            if (today is >= 18 and < 24)
            {
                greeting = "Good Evening";
            }

            navbarViewModel.Greeting = greeting;
            navbarViewModel.Categories = await _newsService.GetAllCategories();

            return View("Default", navbarViewModel);
        }
    }
}
