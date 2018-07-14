using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlogSite.Data;
using BlogSite.ViewModels;

namespace BlogSite.Service.Articles
{
    public class ArticleRepository : IArticleRepository
    {
        private GenericUnitofWork uof;

        public ArticleRepository(BlogContext context)
        {
            uof = new GenericUnitofWork(context);
        }


        public IEnumerable<ArticleMedia> GetPopularArticleList()
        {
          
         
            return (uof.Repository<ArticleMedia>().OrderByDescending(x => x.Article.Views).Take(5).ToList());
            
        }
    }
}
