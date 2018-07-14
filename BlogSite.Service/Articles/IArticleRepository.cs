using BlogSite.Data;
using BlogSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSite.Service.Articles
{
    public  interface IArticleRepository
    {



         IEnumerable<ArticleMedia> GetPopularArticleList();

                
    }
}
