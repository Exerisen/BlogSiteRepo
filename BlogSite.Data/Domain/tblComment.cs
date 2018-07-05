using System;

namespace BlogSite.Data
{
    public class tblComment:BaseEntity
    {
        public string Nickname{get;set;}
       public string Title { get; set; }
       public string CommentContent { get; set; }
       public int ArticleID { get; set; }
       public DateTime SubmitDate { get; set; }
       public bool isActive { get; set; }
       
       public tblArticle tblArticle { get; set; }
    }    
}