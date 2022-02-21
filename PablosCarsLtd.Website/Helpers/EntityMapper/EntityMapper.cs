using NuGet.Packaging;
using PablosCardLtd.News.Domain;
using PablosCardLtd.News.Entities;
using PablosCarsLtd.Website.Models.CreateArticleViewModel;

namespace PablosCarsLtd.Website.Helpers.EntityMapper
{
    public class EntityMapper
    {
        private readonly INewsService _newsService;

        public EntityMapper(INewsService newsService)
        {
            _newsService = newsService;
        }

        public Article MapToArticle(CreateArticleViewModel article)
        {
            var articleBuild = new Article()
            {
                Author = _newsService.GetUserById(article.AuthorId),
                Title = article.Title,
                Content = article.Content,
                ImageUrl = article.ImageUrl,
                Category = new Category(),
                CreatedAt = DateTime.Now,
                ViewCount = new ViewCount()
            };

            var test = _newsService.GetCategoryById(article.CategoryId);
            articleBuild.Category = test;
            articleBuild.ViewCount.Article = articleBuild;

            return articleBuild;
        }
    }
}
