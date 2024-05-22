using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webgreen.Models.Models
{
    public class cats
    {
        [Key]
        // we can also name it as catsid .. it will auto take that this is primary key
        public int id { get; set; }
        [Required]
        // required means not null 
        [DisplayName("name")]
        [MaxLength(25)]
        public string name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,90,ErrorMessage ="give the actual and correct number")]
        public int displayorder { get; set; }
    }
}
