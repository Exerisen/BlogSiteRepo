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
     

        public DbSet<Article> Article{get;set;}
        public DbSet<ArticleMedia> ArticleMedias{ get; set; }
        public DbSet<ArticleTag> ArticleTags{get;set;}
        public DbSet<Author> Author { get; set; }
        public DbSet<Category> Category{get;set;}
        public DbSet<Comment> Comment { get; set; }   
        public DbSet<Media> Media { get; set; }
        public DbSet<Tag> Tag { get; set; }   
        public DbSet<Visitor> Visitor { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
           .HasOne(p => p.Media)
           .WithMany(b => b.Articles)
           .HasForeignKey(p => p.MediaID)
           .HasConstraintName("FK_Article_Media_MediaID");


            modelBuilder.Entity<ArticleMedia>().HasKey(sc => new { sc.ArticleID, sc.MediaID });

            modelBuilder.Entity<ArticleMedia>()
                .HasOne<Article>(sc => sc.Article)
                .WithMany(s => s.ArticleMedias)
                .HasForeignKey(sc => sc.ArticleID);


            modelBuilder.Entity<ArticleMedia>()
                .HasOne<Media>(sc => sc.Media)
                .WithMany(s => s.ArticleMedias)
                .HasForeignKey(sc => sc.MediaID);


            modelBuilder.Entity<ArticleTag>().HasKey(sc => new { sc.ArticleID, sc.TagID });


            modelBuilder.Entity<ArticleTag>()
               .HasOne<Article>(sc => sc.Article)
               .WithMany(s => s.ArticleTags)
               .HasForeignKey(sc => sc.ArticleID);


            modelBuilder.Entity<ArticleTag>()
                .HasOne<Tag>(sc => sc.Tag)
                .WithMany(s => s.ArticleTags)
                .HasForeignKey(sc => sc.TagID);


           



        }
    }
}
