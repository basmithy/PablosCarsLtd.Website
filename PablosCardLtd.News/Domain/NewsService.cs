using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PablosCardLtd.News.Entities;

namespace PablosCardLtd.News.Domain
{
    public class NewsService : INewsService
    {
        private readonly NewsDbContext _context;

        public NewsService(NewsDbContext context)
        {
            _context = context;
        }

        public async Task AddArticle(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Article>> GetAllArticles()
        {
            return await _context.Articles.Include(x => x.ViewCount)
                .Include(x => x.Category)
                .Include(x => x.Author).ToListAsync();
        }

        public async Task<Article> GetSingleArticleById(string articleId)
        {
            return _context.Articles
                .Include(x => x.Category)
                .Include(x => x.Author)
                .Include(x => x.ViewCount)
                .First(x => x.ArticleId == new Guid(articleId));
        }

        public async Task<ICollection<Article>> GetRelatedArticles(Article article)
        {
            var mainArticle = _context.Articles.First(x => x == article);
            
            return await _context.Articles
                .Include(x => x.Category)
                .Include(x => x.Author)
                .Include(x => x.ViewCount)
                .Where(x => x.Category == article.Category && x != mainArticle)
                .ToListAsync();
        }

        public async Task<ICollection<Article>> GetHeadContent()
        {
            var threeCategories = _context.Categories.OrderBy(x => x.CategoryName).Take(3).ToList();

            return await _context.Articles.Include(x => x.ViewCount)
                .Include(x => x.Category)
                .Include(x => x.Author)
                .Where(x => threeCategories.Any(y => y == x.Category))                                                                      
                .GroupBy(x => x.Category.CategoryId)
                .Select(x => x.OrderByDescending(y => y.CreatedAt).First())
                .ToListAsync();
        }

        public async Task<ICollection<Article>> GetLatestNews(ICollection<Article> headContent)
        {
            var baseArticles = await _context.Articles
                .Include(x => x.Author)
                .Include(x => x.Category)
                .Include(x => x.ViewCount)
                .ToListAsync();

            var latestArticles = baseArticles.Except(headContent).OrderByDescending(x => x.CreatedAt).ToList();
            return latestArticles;
        }

        public async Task<ICollection<Article>> GetMostViewed()
        {
            return await _context.Articles.Include(x => x.ViewCount)
                .Include(x => x.Category)
                .Include(x => x.Author)
                .OrderByDescending(x => x.ViewCount.ViewCountAmount)
                .Take(5)
                .ToListAsync();
        }

        public async Task<ICollection<Article>> GetArticlesByCategoryId(string categoryId)
        {
            return await _context.Articles
                .Include(x => x.Category)
                .Include(x => x.Author)
                .Include(x => x.ViewCount)
                .Where(x => x.Category.CategoryId == new Guid(categoryId))
                .ToListAsync();
        }

        public async Task<ICollection<Category>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public Category GetCategoryById(Guid category)
        {
            return _context.Categories.First(x => x.CategoryId == category);
        }

        public StaffUser GetUserById(string id)
        {
            if (id == null) return new StaffUser();

            return _context.StaffUsers.First(x => x.Id == new Guid(id));
        }

        public async Task IncreaseViewCount(string articleId)
        {
            // get article
            var article = _context.Articles
                .Include(x => x.ViewCount)
                .First(x => x.ArticleId == new Guid(articleId));
            article.ViewCount.ViewCountAmount += 1;

            await _context.SaveChangesAsync();
        }

    }
}
