using CMS2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS2017.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext(); 
        // GET: Movie
        public ActionResult Index()
        {
           IEnumerable<Movie> moviesList=_context.Movies.ToList();

            return View(moviesList);
        }
        [HttpGet]
        public ActionResult AddMovie()
        {
            //to display add movie
            return View("CreateMovie");
        }
        //create a movies send data to db
        [HttpPost]
        public ActionResult AddMovie(Movie movieObj)
        {
            //check that the model is valid 
            if (!ModelState.IsValid)
            { }
            else
            {
                //you have to check if movieObj is not an update of existing one
                //add movie to db
                movieObj.DateAdded = DateTime.Now;
                _context.Movies.Add(movieObj);
                _context.SaveChanges();
            }
            //redirect to action index and controller movie 
                return RedirectToAction("index","Movie");

        }
       
        
        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            Movie movieInDb=_context.Movies.SingleOrDefault(m => m.Id == id);
            return View(movieInDb);
        }
    }
}