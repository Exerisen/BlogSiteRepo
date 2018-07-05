using System;
using Microsoft.EntityFrameworkCore;
namespace  BlogSite.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options ):base(options)
        {
            //MODELDE DEÐÝÞÝKLÝK OLURSA DATABASEÝ GÜNCELLEYEN KODU BUL.
                       // Database.SetInitializer<BlogContext>(new DropCreateDatabaseIfModelChanges<BlogContext>());

        }
  
        
        public DbSet<tblArticle> tblArticle{get;set;}
        public DbSet<tblArticleImage> tblArticleImage { get; set; }
        public DbSet<tblArticleTag> tblArticleTag{get;set;}
        public DbSet<tblAuthor> tblAuthor { get; set; }
        public DbSet<tblCategory> tblCategory{get;set;}
        public DbSet<tblComment> tblComment { get; set; }   
        public DbSet<tblMedia> tblMedia { get; set; }

        public DbSet<tblTag> tblTag { get; set; }   
        public DbSet<tblVisitor> tblVisitor { get; set; }

    }
}
