using System.ComponentModel.DataAnnotations;

namespace BlogSite.Data
{
    public class tblArticleImage:BaseEntity
    {

        public int ArticleID { get; set; }

        public int ImageID { get; set; }

        public tblArticle Article{get;set;}
        public tblMedia Image{get;set;}
    }    
}