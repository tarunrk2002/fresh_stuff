using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webgreen.Models
{
    public class cats
    {
        [Key]
        // we can also name it as catsid .. it will auto take that this is primary key
        public int id { get; set; }
        [Required]
        // required means not null 
        [DisplayName("name")]
        public string name { get; set; }
        [DisplayName("Display Order")]
        public int displayorder { get; set; }
    }
}
