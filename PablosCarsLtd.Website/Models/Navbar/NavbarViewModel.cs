using PablosCardLtd.News.Entities;

namespace PablosCarsLtd.Website.Models.Navbar
{
    public class NavbarViewModel
    {
        public string Greeting { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
