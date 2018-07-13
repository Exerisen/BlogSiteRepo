using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSite.Data
{
    public class Media:BaseEntity
    {
  

        public string Name { get; set; }
        public string SmallPath { get; set; }
        public string MediumPath{get;set;}
        public string LargePath{get;set;}
        public string VideoPath { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UploadDate { get; set; }


        public virtual ICollection<ArticleMedia> ArticleMedias { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
    
}