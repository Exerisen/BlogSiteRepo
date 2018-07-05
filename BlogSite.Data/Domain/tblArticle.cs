using System;
using System.Collections;
using System.Collections.Generic;
namespace BlogSite.Data
{
    public class tblArticle:BaseEntity
    {
        
        private IList<tblArticleImage> _tblArticleImage{get;set;}
        private IList<tblArticleTag> _tblArticleTag {get;set;}
    public tblArticle()
    {
      _tblArticleImage= new List<tblArticleImage>();
      _tblArticleTag=new List<tblArticleTag>();
    }

        public string Title { get; set; }
        public string ArticleContent { get; set; }
        public string Summary { get; set; }
        public DateTime PublishDate{get;set;}
        public int CategoryID { get; set; }
        public Guid PublisherID { get; set; }
        public int CoverImageID { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public bool isActive { get; set; }

        public tblCategory tblCategory{get;set;}
        public tblAuthor tblAuthor{get;set;}
        public tblMedia tblMedia{get;set;}
        public  IList<tblArticleImage> tblArticleImage { get; set; }
        public IList<tblArticleTag> tblArticleTag { get; set; }

    }
}