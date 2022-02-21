using PablosCardLtd.News.Entities;

namespace PablosCarsLtd.Website.Models.ArticleViewModel
{
    public class ArticleViewModel
    {
        public Article Article { get; set; }
        public ICollection<Article> RelatedArticles { get; set; }
    }
}
