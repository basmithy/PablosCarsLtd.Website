using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using PablosCardLtd.News.Entities;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PablosCarsLtd.Website.Models.CreateArticleViewModel
{
    public class CreateArticleViewModel
    {
        [Required(ErrorMessage = "*required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "*required")]
        public string Content { get; set; }
        [Required(ErrorMessage = "*required")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "*required")]
        public Guid CategoryId { get; set; }
        public string AuthorId { get; set; }
        [ValidateNever]
        public string ArticleResultMessage { get; set; }
    }
}
