using System;
namespace BlogSite.Data
{
    public class tblMedia:BaseEntity
    {
        public string Name { get; set; }
        public string SmallPath { get; set; }
        public string MediumPath{get;set;}
        public string LargePath{get;set;}
        public string VideoPath { get; set; }
      
        public DateTime UploadDate { get; set; }



    }
    
}