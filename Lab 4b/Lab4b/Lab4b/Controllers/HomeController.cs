using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _MovieContext;

        public HomeController(MovieContext context)
        {
            _MovieContext = context;
        }

        public IActionResult Index()
        {
            return View(_MovieContext.Movies.ToList());
        }

        public IActionResult AddMovie()
        {
            return View();
        }

        public IActionResult CreateMovie(Movies movie)
        {
            if (ModelState.IsValid)
            {
                _MovieContext.Movies.Add(movie);
                _MovieContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditMovie(int id)
        {
            var movieToUpdate = (from m in _MovieContext.Movies where m.MovieId == id select m).FirstOrDefault();

            return View(movieToUpdate);
        }

        public IActionResult ModifyMovie(Movies movie)
        {
            var id = Convert.ToInt32(Request.Form["MovieId"]);

            var movieToUpdate = (from m in _MovieContext.Movies where m.MovieId == id select m).FirstOrDefault();
            movieToUpdate.Title = movie.Title;
            movieToUpdate.SubTitle = movie.SubTitle;
            movieToUpdate.Description = movie.Description;
            movieToUpdate.Year = movie.Year;
            movieToUpdate.Rating = movie.Rating;

            _MovieContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteMovie(int id)
        {
            var movie = (from m in _MovieContext.Movies where m.MovieId == id select m).FirstOrDefault();

            _MovieContext.Remove(movie);
            _MovieContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}