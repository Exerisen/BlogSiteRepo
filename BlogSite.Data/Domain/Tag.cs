using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlogSite.Data
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }

        virtual public ICollection<ArticleTag> ArticleTags { get; set; }         
    }
}