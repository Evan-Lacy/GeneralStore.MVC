using GeneralStore.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStore.MVC.Controllers
{
    public class ReviewController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Review
        public ActionResult Index()
        {
            List<Review> reviewList = _db.Reviews
                .OrderBy(review => review.ReviewId)
                .ThenBy(review => review.DateofReviewUTC)
                .ToList();
            return View(reviewList);
        }

        //GET: Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            if (ModelState.IsValid) 
            { 
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }
    }
}