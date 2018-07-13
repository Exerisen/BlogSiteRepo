using BlogSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.ViewModels
{
    public class ArticleViewModel
    {
        public Article Article { get; set; }
        public Media Media { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }

    }
}
