using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PablosCardLtd.News.Entities
{
    public class ArticleCategory
    {
        public Guid ArticleCategoryId { get; set; }

        public Guid ArticleId { get; set; }
        public Article Article { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
