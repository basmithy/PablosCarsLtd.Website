using PablosCardLtd.News.Entities;

namespace PablosCarsLtd.Website.Models.NewsFeed
{
    public class NewsFeedViewModel
    {
        public ICollection<Article> HeadContent { get; set; }
        public ICollection<Article> LatestNews { get; set; }
        public ICollection<Article> MostViewed { get; set; }
    }
}
