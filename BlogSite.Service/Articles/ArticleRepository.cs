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


        public IEnumerable<Article> GetPopularArticleList()
        {
          
         
            return (uof.Repository<Article>().OrderByDescending(x => x.Views).Take(5).ToList());
            
        }
    }
}
