using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webgreen.Models.Models
{
    public class Product
    {

        //ID
        [Key]
        public int Id { get; set; }
       
        
        //TITLE
        [Required]
        [MaxLength(60)]
        public string Title { get; set; }
        
        //DESCRIPTION
        public string Description { get; set; }
       
        
        //ISBN
        [Required]
        public string ISBN { get; set; }
       
        

        //AUTHOR
        [Required]
        public string Author { get; set; }
       
        
        //LISTPRICE
        [Required]
        [Display(Name = "List Price")]
        [Range(1,1000)]

        public double ListPrice { get; set; }

       

        //PRICE
        
        [Required]
        [Display(Name = "Price for 1-50")]
        [Range(1, 1000)]
        public double Price { get; set; }
        

        //PRICE50
        [Required]
        [Display(Name = "Price for 1-50")]
        [Range(1, 1000)]
        public double Price50 { get; set; }




        //PRICE100
        [Required]
        [Display(Name = "Price for 100+")]
        [Range(1, 1000)]
        public double Price100 { get; set; }




        //CATEGORYid
        public int Categoryid { get; set; }


        //another class's table 
        [ForeignKey("Categoryid")]
        public cats catfromanotherclass { get; set; }

        public string imageurl { get; set; }

    }
}
