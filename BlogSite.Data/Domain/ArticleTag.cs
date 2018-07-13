namespace BlogSite.Data
{
    public class ArticleTag

    {
        public int ID { get; set; }
        public int ArticleID { get; set; }
        public int TagID { get; set; }

        public virtual Article Article { get; set; }
        public virtual Tag Tag { get; set; }
    }    
}