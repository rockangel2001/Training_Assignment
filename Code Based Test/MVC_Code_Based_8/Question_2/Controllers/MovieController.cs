//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace Question_2.Controllers
//{
//    public class MovieController : Controller
//    {
//        // GET: Movie
//        public ActionResult Index()
//        {
//            return View();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Question_2.Models;
using System.Data.Entity;
using System.Net;

namespace Solution_2.Controllers
{
    public class MovieController : Controller
    {
        private MovieDB db = new MovieDB();
        // GET: Movie
        public ActionResult Index()
        {
            return View(db.Movie.ToList());
        }

        // Details of Movie
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var movie = db.Movie.Find(id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }


        // Create a new movie
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            db.Movie.Add(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Edit an existing movie

        public ActionResult Edit(int id)
        {
            var movie = db.Movie.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Delete a movie
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var movie = db.Movie.Find(id);
            db.Movie.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Display movies released in a given year
        public ActionResult MoviesByYear(int year)
        {
            var moviesInYear = db.Movie.Where(m => m.DateofRelease.Year == year).ToList();
            return View(moviesInYear);
        }
    }
}