using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace BlogSite.Data
{
    public class tblAuthor //BASEENTÝTY SORUNU OLABÝLÝR DÝKKAT.
    {

        [Required]
        public Guid ID{get;set;}
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string MailAdress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int ImageID { get; set; }
        public bool isActive { get; set; }

        public tblMedia tblMedia { get; set; }
 
    }
    
}