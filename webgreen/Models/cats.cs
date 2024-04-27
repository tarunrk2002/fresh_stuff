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
        public string name { get; set; }
        public int displayorder { get; set; }
    }
}
