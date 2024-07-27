using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FreeCodeCamp.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public String Name { get; set; }

        [DisplayName("Display order")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
