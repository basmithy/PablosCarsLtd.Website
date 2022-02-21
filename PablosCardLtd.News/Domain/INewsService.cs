using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PablosCardLtd.News.Entities;

namespace PablosCardLtd.News.Domain
{
    public interface INewsService
    {
        Task AddArticle(Article article);
        Task<ICollection<Article>> GetHeadContent();
        Task<ICollection<Article>> GetLatestNews(ICollection<Article> headContent);
        Task<ICollection<Article>> GetMostViewed();
        StaffUser GetUserById(string id);
        Category GetCategoryById(Guid category);
        Task<ICollection<Article>> GetAllArticles();
        Task<Article> GetSingleArticleById(string articleId);
        Task<ICollection<Article>> GetRelatedArticles(Article article);
        Task IncreaseViewCount(string articleId);
        Task<ICollection<Category>> GetAllCategories();
        Task<ICollection<Article>> GetArticlesByCategoryId(string categoryId);
    }
}
