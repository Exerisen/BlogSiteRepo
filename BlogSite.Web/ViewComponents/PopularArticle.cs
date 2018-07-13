using BlogSite.Data;
using BlogSite.Service.Articles;
using BlogSite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Components
{
    [ViewComponent(Name = "PopularArticle")]
    public class PopularArticle:ViewComponent
    {
       private readonly IArticleRepository repo;

        public PopularArticle(BlogContext context)
        {

            repo = new ArticleRepository(context);    
        }

        public IViewComponentResult Invoke()
        {

            return View(repo.GetPopularArticleList());
        }

    }
}
