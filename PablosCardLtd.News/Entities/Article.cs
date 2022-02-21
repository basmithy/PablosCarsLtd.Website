using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PablosCardLtd.News.Entities
{
    public class Article
    {
        public Guid ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }


        public Category Category { get; set; }
        [ForeignKey("ViewCountId")]
        public ViewCount ViewCount { get; set; }
        public StaffUser Author { get; set; }
    }
}
