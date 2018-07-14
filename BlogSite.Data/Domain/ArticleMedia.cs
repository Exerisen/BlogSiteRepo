using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSite.Data
{
    public class ArticleMedia
    {

        public int ID { get; set; } //SÝL


        public int ArticleID { get; set; }
        public virtual Article Article { get; set; }


        public int MediaID { get; set; }
        public virtual Media Media { get; set; }
    }    
}