using BlogSite.Data;
using BlogSite.Service.Articles;
using BlogSite.Service.Categories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.ViewComponents
{
    [ViewComponent(Name = "MenuViewComponent")]
    public class MenuViewComponent : ViewComponent
    {
        CategoryRepository repo;

        public MenuViewComponent(BlogContext context)
        {
            repo = new CategoryRepository(context);
        }

        public IViewComponentResult Invoke()
        {


            return View(repo.GetAll());

        }

    }
}
