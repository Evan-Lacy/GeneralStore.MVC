using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        //Each review is tied to a specific product and a specific Customer by way of Id numbers.
        //This way, when accessing the products or customers, you can see lists of all the reviews on an object or left by a certain customer
        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        //Make Reviews on a scale of 1-10
        [Required]
        [Range(1,10,ErrorMessage =("Please Enter a Rating between 1 and 10."))]
        public int Rating { get; set; }
        //Review Header to show off a quick summary of the content of the review
        [Required]
        [MaxLength(100, ErrorMessage = "Please make your Header shorter.")]
        [Display(Name = "Review Header")]
        public string ReviewHeader { get; set; }
        [Required]
        [MaxLength(1000, ErrorMessage ="Please condense your review to be 1000 characters or less.")]
        public string ReviewText { get; set; }
        [Display(Name ="Created(UTC):")]
        public DateTimeOffset DateofReviewUTC { get; set; }
    }
}