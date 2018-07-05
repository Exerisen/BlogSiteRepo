namespace BlogSite.Data
{
    public class tblArticleTag:BaseEntity
    {
        public int ArticleID { get; set; }
        public int TagID { get; set; }

        public tblArticle Article { get; set; }
        public tblTag Tag { get; set; }
    }    
}