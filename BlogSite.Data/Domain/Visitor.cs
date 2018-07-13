using System;

namespace BlogSite.Data
{
    public class Visitor:BaseEntity
    {
      public string IPAdress { get; set; }
      public DateTime VisitDate { get; set; }
      
    }    
}