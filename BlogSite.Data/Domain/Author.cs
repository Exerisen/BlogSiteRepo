using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace BlogSite.Data
{
    public class Author //BASEENT�TY SORUNU OLAB�L�R D�KKAT.
    {

        [Required]
        public Guid ID{get;set;}
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string MailAdress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int MediaID { get; set; }
        public virtual Media Media { get; set; }
        public bool isActive { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
            
    

    }
    
}