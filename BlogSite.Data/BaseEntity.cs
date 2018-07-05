using System.ComponentModel.DataAnnotations;

namespace BlogSite.Data
{
    public class BaseEntity
    {
        [Required]
        public int ID { get; set;}            
    }


}
