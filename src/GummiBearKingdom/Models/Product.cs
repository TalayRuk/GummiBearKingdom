using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GummiBearKingdom.Models
{
    [Table("Products")]
    //Table Naming Convention need to be plural
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string ImageURL { get; set; }
        public string Country_origin { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        //one to many relationship Category has many products 

    }
}

