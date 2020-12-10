using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class ReviewListItem
    {
        [Display(Name = "Review Number:")]
        public int ReviewId { get; set; }
        public int Rating { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Review Header")]
        public string ReviewHeader { get; set; }
        [Display(Name = "Review Text")]
        public string ReviewText { get; set; }
        [Display(Name = "Date of Review")]
        public DateTimeOffset DateofReviewUTC { get; set; }
    }
}