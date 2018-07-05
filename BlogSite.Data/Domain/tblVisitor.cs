using System;

namespace BlogSite.Data
{
    public class tblVisitor:BaseEntity
    {
      public string IPAdress { get; set; }
      public DateTime VisitDate { get; set; }
      
    }    
}