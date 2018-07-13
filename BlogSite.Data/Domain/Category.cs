using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSite.Data
{

    public class Category:BaseEntity
    {
        public string Name { get; set; }      

         public virtual ICollection<Article> Articles{get;set;}       
    }
    
}