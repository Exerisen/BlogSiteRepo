using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSite.Data
{
    public class Article:BaseEntity
    {

        public string Title { get; set; }
        public string ArticleContent { get; set; }
        public string Summary { get; set; }
        public DateTime PublishDate{get;set;}

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int MediaID { get; set; }
        public virtual Media Media { get; set; }

        public Guid AuthorID { get; set; }
        public virtual  Author Author { get; set; }

        public int Views { get; set; }
        public int Likes { get; set; }
        public bool isActive { get; set; }


        public virtual ICollection<ArticleMedia> ArticleMedias { get; set; }
        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}