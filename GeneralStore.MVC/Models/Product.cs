using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "# in Stock")]
        public int InventoryCount { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        [Display(Name = "It is food")]
        public bool IsFood { get; set; }

        //Products can now hold a list of all the reviews left by customers on them.
        public virtual List<Review> Reviews { get; set; } = new List<Review>();
    }
}